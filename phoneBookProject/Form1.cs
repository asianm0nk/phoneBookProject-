namespace phoneBookProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
