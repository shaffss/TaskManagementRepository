using Commons.Enumerators;
using Commons.Exceptions;
using Commons.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagementRepository;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsUI
{
    public partial class Form2 : Form
    {
        private object Obj { get; set; }
        private Config Config { get; set; }
        private Form1 form1 {  get; set; }

        public Form2(Config config, Form1 form)
        {
            this.Obj = config;
            this.Config = config;
            this.form1 = form;
            InitializeComponent();
            button3.Visible = false;
            comboBox1.DataSource = Enum.GetValues(typeof(Priority));
            comboBox1.SelectedIndex = -1;
        }
        public Form2(UserTask task, Config config, Form1 form)
        {
            this.Obj = task;
            this.Config = config;
            this.form1 = form;
            InitializeComponent();
            label6.Text = "<Edit Task>";
            button3.Visible = true;
            textBox2.Text = task.Header;
            comboBox1.DataSource = Enum.GetValues(typeof(Priority));
            comboBox1.SelectedItem = task.Priority;
            textBox1.Text = task.Description;
            textBox3.Text = task.Assignee.Name;
            textBox4.Text = string.Join(",", task.Users.Select(user => user.Name));
        }

        private void SetTaskValues(UserTask task)
        {
            try
            {
                task.Header = textBox2.Text;
                task.Priority = comboBox1.SelectedItem is Priority selectedPriority
                        ? selectedPriority
                        : Priority.Normal;
                task.Description = textBox1.Text;

                task.Assignee = GetUserByName(textBox3.Text);
                foreach (string username in textBox4.Text.Split(','))
                    if (username != string.Empty)
                        if (!task.Users.Any(user => user.Name == username))
                            task.Users.Add(GetUserByName(username));

                task.DateTime = DateTime.Now;
            }
            catch (UserNotFoundException) { }


        }

        private Commons.Models.User GetUserByName(string name)
        {
            Commons.Models.User? user;
            if ((user = Config.Managers.FirstOrDefault(manager => manager.Name == name)) is null)
                foreach (var manager in Config.Managers)
                    if ((user = manager.Employees.FirstOrDefault(Employee => Employee.Name == name)) is not null)
                        break;
            if (user is null)
            {
                MessageBox.Show("User not found!");
                throw new UserNotFoundException();
            }
            return user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Obj.GetType() == typeof(UserTask)) SetTaskValues((UserTask)Obj);
            else if (Obj.GetType() == typeof(Config))
            {
                Config config = (Config)Obj;
                UserTask task = new UserTask();

                SetTaskValues(task);
                config.UserTasks.Add(task);
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) =>
            this.Close();

        private void button3_Click(object sender, EventArgs e)
        {
            Config.UserTasks.Remove((UserTask)Obj);
            this.Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            form1.UpdateTaskView();
        }
    }
}
