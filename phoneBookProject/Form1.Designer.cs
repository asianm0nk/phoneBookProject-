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
            tablePanel = new TableLayoutPanel();
            CreateBTN = new Button();
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
            SearchBTN = new Button();
            textBoxSearch = new TextBox();
            CancelBTN = new Button();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tablePanel
            // 
            tablePanel.AutoScroll = true;
            tablePanel.ColumnCount = 1;
            tablePanel.ColumnStyles.Add(new ColumnStyle());
            tablePanel.Location = new Point(274, 46);
            tablePanel.Name = "tablePanel";
            tablePanel.RowCount = 1;
            tablePanel.RowStyles.Add(new RowStyle());
            tablePanel.Size = new Size(514, 392);
            tablePanel.TabIndex = 0;
            // 
            // CreateBTN
            // 
            CreateBTN.Location = new Point(31, 391);
            CreateBTN.Name = "CreateBTN";
            CreateBTN.Size = new Size(94, 29);
            CreateBTN.TabIndex = 1;
            CreateBTN.Text = "Create";
            CreateBTN.UseVisualStyleBackColor = true;
            CreateBTN.Click += CreateBTN_Click;
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
            // SearchBTN
            // 
            SearchBTN.Location = new Point(525, 11);
            SearchBTN.Name = "SearchBTN";
            SearchBTN.Size = new Size(94, 29);
            SearchBTN.TabIndex = 0;
            SearchBTN.Text = "Search";
            SearchBTN.UseVisualStyleBackColor = true;
            SearchBTN.Click += SearchBTN_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(310, 12);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(209, 27);
            textBoxSearch.TabIndex = 12;
            // 
            // CancelBTN
            // 
            CancelBTN.Location = new Point(146, 391);
            CancelBTN.Name = "CancelBTN";
            CancelBTN.Size = new Size(94, 29);
            CancelBTN.TabIndex = 13;
            CancelBTN.Text = "Cancel";
            CancelBTN.UseVisualStyleBackColor = true;
            CancelBTN.Click += CancelBTN_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Desc", "Asc" });
            comboBox1.Location = new Point(625, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 524);
            Controls.Add(comboBox1);
            Controls.Add(CancelBTN);
            Controls.Add(textBoxSearch);
            Controls.Add(SearchBTN);
            Controls.Add(panel1);
            Controls.Add(CreateBTN);
            Controls.Add(tablePanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tablePanel;
        private Button CreateBTN;
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
        private Button SearchBTN;
        private TextBox textBoxSearch;
        private Button CancelBTN;
        private ComboBox comboBox1;
    }
}
