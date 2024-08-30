using Commons.Enumerators;
using Commons.Models;
using System.Threading.Tasks;
using WinFormsUI;
using System.Linq;
using System.Windows.Forms;

namespace TaskManagementRepository
{
    public partial class Form1 : Form
    {
        Config config { get; set; }
        public Form1(Config config)
        {
            InitializeComponent();

            config.Managers.ForEach(manager =>
            {
                treeView1.Nodes.Add(manager.Name);
                manager.Employees.ForEach(employee =>
                {
                    treeView1.Nodes.Add("   " + employee.Name);
                });
            });
            this.config = config;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) =>
            UpdateTaskView(e.Node.Text, tabControl1.SelectedTab.Text);

        private void tabControl1_Click(object sender, EventArgs e) =>
            UpdateTaskView(treeView1.SelectedNode.Text, tabControl1.SelectedTab.Text);
        private void tabControl2_Click(object sender, EventArgs e) =>
            UpdateTaskView(treeView1.SelectedNode.Text, tabControl2.SelectedTab.Text);

        public void UpdateTaskView() =>
            UpdateTaskView(treeView1.SelectedNode.Text, tabControl1.SelectedTab.Text);
        private void UpdateTaskView(string user, string tab)
        {
            listView1.Clear();
            label3.Text = user.Trim();
            if (config.Managers.Any(manager => manager.Name == user.Trim()))
                tabControl2.Visible = true;
            else
                tabControl2.Visible = false;
            switch (tab)
            {
                case "My Tasks":
                    foreach (UserTask task in config.UserTasks.Where(task =>
                        task.Assignee.Name == user.Trim()))
                        listView1.Items.Add(new ListViewItem(task.Header));
                    break;
                case "Tasks shared with me":
                    foreach (UserTask task in
                        config.UserTasks.Where(task =>
                            task.Users.Any(
                                _user =>
                                    _user.Name == user.Trim())))
                        listView1.Items.Add(new ListViewItem(task.Header));
                    break;
                case "My employees tasks":
                    foreach (Employee employee in config.Managers.Where(manager =>
                        manager.Name == user.Trim())
                            .First()
                                .Employees)
                    {
                        listView1.Items.Add(new ListViewItem(employee.Name));
                        foreach (UserTask task in config.UserTasks.Where(task =>
                            task.Assignee.Name == employee.Name))
                            listView1.Items.Add(new ListViewItem(task.Header));
                    }
                    break;
                case "Employee monthly stats":
                    foreach (Month month in Enum.GetValues(typeof(Month)))
                    {
                        listView1.Items.Add(new ListViewItem(month.ToString()));
                        foreach (Employee employee in config.Managers.Where(manager =>
                            manager.Name == user.Trim())
                                .First()
                                    .Employees)
                            listView1.Items.Add(new ListViewItem(employee.Name + " " +
                                config.UserTasks.Where(task =>
                                    task.Assignee.Name == employee.Name
                                    &&
                                    task.DateTime.Month == ((int)month))
                                        .Count()));
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2(config, this).ShowDialog();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            UserTask? userTask = config.UserTasks.Where(task =>
                task.Header
                ==
                listView1.SelectedItems
                    .Cast<ListViewItem>()
                        .FirstOrDefault()?
                            .Text)
                .FirstOrDefault();

            if (userTask is null) return;

            new Form2(userTask, config, this).ShowDialog();
        }
    }
}
