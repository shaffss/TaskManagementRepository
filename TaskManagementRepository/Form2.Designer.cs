namespace WinFormsUI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 99);
            label1.Name = "label1";
            label1.Size = new Size(85, 30);
            label1.TabIndex = 0;
            label1.Text = "Header:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 158);
            label2.Name = "label2";
            label2.Size = new Size(83, 30);
            label2.TabIndex = 1;
            label2.Text = "Priority:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 219);
            label3.Name = "label3";
            label3.Size = new Size(123, 30);
            label3.TabIndex = 2;
            label3.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 279);
            label4.Name = "label4";
            label4.Size = new Size(101, 30);
            label4.TabIndex = 3;
            label4.Text = "Assignee:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 341);
            label5.Name = "label5";
            label5.Size = new Size(132, 30);
            label5.TabIndex = 4;
            label5.Text = "Shared With:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(317, 35);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(198, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(317, 35);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(198, 274);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(317, 35);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(198, 338);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(317, 35);
            textBox4.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(198, 153);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(317, 38);
            comboBox1.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 36);
            label6.Name = "label6";
            label6.Size = new Size(128, 30);
            label6.TabIndex = 10;
            label6.Text = "<New Task>";
            // 
            // button1
            // 
            button1.Location = new Point(297, 422);
            button1.Name = "button1";
            button1.Size = new Size(106, 45);
            button1.TabIndex = 11;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(409, 422);
            button2.Name = "button2";
            button2.Size = new Size(106, 45);
            button2.TabIndex = 12;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(58, 371);
            label7.Name = "label7";
            label7.Size = new Size(196, 30);
            label7.TabIndex = 13;
            label7.Text = "(Comma Separated)";
            // 
            // button3
            // 
            button3.Location = new Point(384, 36);
            button3.Name = "button3";
            button3.Size = new Size(131, 40);
            button3.TabIndex = 14;
            button3.Text = "Delete Task";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 545);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Label label6;
        private Button button1;
        private Button button2;
        private Label label7;
        private Button button3;
    }
}