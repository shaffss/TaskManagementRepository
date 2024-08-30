namespace TaskManagementRepository
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeView1 = new TreeView();
            listView1 = new ListView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tabControl2 = new TabControl();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            button1 = new Button();
            tabControl1.SuspendLayout();
            tabControl2.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(42, 77);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(264, 299);
            treeView1.TabIndex = 0;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // listView1
            // 
            listView1.Location = new Point(311, 77);
            listView1.Name = "listView1";
            listView1.Size = new Size(938, 299);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            listView1.Click += listView1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(456, 382);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(324, 39);
            tabControl1.TabIndex = 2;
            tabControl1.Click += tabControl1_Click;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(316, 0);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "My Tasks";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 39);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(316, 0);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tasks shared with me";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 36);
            label1.Name = "label1";
            label1.Size = new Size(149, 30);
            label1.TabIndex = 3;
            label1.Text = "User Selection:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 36);
            label2.Name = "label2";
            label2.Size = new Size(107, 30);
            label2.TabIndex = 4;
            label2.Text = "Task View:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(428, 36);
            label3.Name = "label3";
            label3.Size = new Size(0, 30);
            label3.TabIndex = 5;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage3);
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Location = new Point(777, 385);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(472, 39);
            tabControl2.TabIndex = 6;
            tabControl2.Click += tabControl2_Click;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 39);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(464, 0);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "My employees tasks";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 39);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(464, 0);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Employee monthly stats";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(1108, 24);
            button1.Name = "button1";
            button1.Size = new Size(141, 47);
            button1.TabIndex = 7;
            button1.Text = "New Task...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 536);
            Controls.Add(button1);
            Controls.Add(tabControl2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Controls.Add(listView1);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private ListView listView1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button button1;
    }
}
