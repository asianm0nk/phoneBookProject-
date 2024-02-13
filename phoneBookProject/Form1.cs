namespace phoneBookProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.Controls.Add(new UserPanel { Name = "test", Phone = "text" });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var panel = new UserPanel { Name = "Hello", Phone = "World! 1" };
            tableLayoutPanel1.Controls.Add(panel);
        }
    }
}
