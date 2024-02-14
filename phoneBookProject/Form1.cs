namespace phoneBookProject
{
    public partial class Form1 : Form
    {
        TableLayoutPanel tableLayoutPanel_forSearch = new TableLayoutPanel();
        public Form1()
        {
            InitializeComponent();
            TableLayoutPanel tableLayoutPanel_forSearch = new TableLayoutPanel
            {
                Location = new Point(274, 46),
                Parent = this
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var panel = new UserPanel(nameBox.Text, phoneBox.Text,
                new User(
                    nameBox.Text,
                    emailBox.Text,
                    phoneBox.Text,
                    lastNameBox.Text,
                    aboutBox.Text
                    ));
            tableLayoutPanel1.Controls.Add(panel);
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            if (tableLayoutPanel_forSearch1.Controls.Count > 0)
            {
                tableLayoutPanel_forSearch1.Controls.Clear();
            }
            foreach (UserPanel item in tableLayoutPanel1.Controls)
            {
                if (
                    item.getUserName().Equals(textBoxSearch.Text) ||
                    item.getUserPhone().Equals(textBoxSearch.Text) && textBoxSearch.Text.Length != 0
                    )
                {
                    tableLayoutPanel_forSearch1.Controls.Add(item);
                }
            }
        }
    }
}
