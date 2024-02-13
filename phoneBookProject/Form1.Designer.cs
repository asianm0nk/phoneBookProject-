namespace phoneBookProject
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            nameBox = new TextBox();
            lastNameBox = new TextBox();
            phoneBox = new TextBox();
            panel1 = new Panel();
            label5 = new Label();
            aboutBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            emailBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Location = new Point(274, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(514, 426);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(78, 377);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(19, 34);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(209, 27);
            nameBox.TabIndex = 2;
            // 
            // lastNameBox
            // 
            lastNameBox.Location = new Point(19, 101);
            lastNameBox.Name = "lastNameBox";
            lastNameBox.Size = new Size(209, 27);
            lastNameBox.TabIndex = 3;
            // 
            // phoneBox
            // 
            phoneBox.Location = new Point(19, 167);
            phoneBox.Name = "phoneBox";
            phoneBox.Size = new Size(209, 27);
            phoneBox.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(aboutBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(emailBox);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(phoneBox);
            panel1.Controls.Add(lastNameBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 341);
            panel1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 271);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 11;
            label5.Text = "About";
            // 
            // aboutBox
            // 
            aboutBox.Location = new Point(19, 294);
            aboutBox.Multiline = true;
            aboutBox.Name = "aboutBox";
            aboutBox.Size = new Size(209, 34);
            aboutBox.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 206);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 9;
            label4.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 144);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 8;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 78);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 7;
            label2.Text = "Last name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 11);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // emailBox
            // 
            emailBox.Location = new Point(19, 229);
            emailBox.Name = "emailBox";
            emailBox.Size = new Size(209, 27);
            emailBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private TextBox nameBox;
        private TextBox lastNameBox;
        private TextBox phoneBox;
        private Panel panel1;
        private Label label5;
        private TextBox aboutBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox emailBox;
    }
}
