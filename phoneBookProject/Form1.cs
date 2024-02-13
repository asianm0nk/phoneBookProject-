namespace phoneBookProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tableLayoutPanel1.Controls.Add(new UserPanel ("ILIA", "HE"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var panel = new UserPanel("ILIA", "HE");
            tableLayoutPanel1.Controls.Add(panel);
        }
    }
}
