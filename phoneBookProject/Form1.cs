using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;

namespace phoneBookProject
{
    public partial class Form1 : Form
    {
        Controller controller;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreateBTN_Click(object sender, EventArgs e)
        {
            if (CreateBTN.Text.Equals("Create"))
            {
                if (this.nameBox.Text.Length > 0 && this.phoneBox.Text.Length > 0)
                {
                    Controller.createUser(this.nameBox.Text, this.lastNameBox.Text, this.phoneBox.Text, this.emailBox.Text, this.aboutBox.Text);
                    update();
                }
                else
                {
                    MessageBox.Show("Name and phone cann't be empty");
                }
            }
            clearInput();
        }

        private void SearchBTN_Click(object sender, EventArgs e)
        {
            if (this.textBoxSearch.Text.Length > 0)
                update(Controller.search_user(this.textBoxSearch.Text, this.comboBox1.Text));
            else
            {
                MessageBox.Show("Length must be > 0");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            update();
        }

        public void update()
        {
            tablePanel.Controls.Clear();
            foreach (var item in Controller.getData(comboBox1.Text))
            {
                tablePanel.Controls.Add(item);
            }
        }

        private void update(List<UserPanel> panels)
        {
            tablePanel.Controls.Clear();
            if (panels != null)
            {
                foreach (var item in panels)
                {
                    tablePanel.Controls.Add(item);
                }
            }

        }

        public void EditUser(User user)
        {
            nameBox.Text = user.Name;
            lastNameBox.Text = user.LastName;
            phoneBox.Text = user.Phone;
            emailBox.Text = user.Email;
            aboutBox.Text = user.about;

            CreateBTN.Text = "Save";
            CreateBTN.Click -= CreateBTN_Click;
            CreateBTN.Click += CreateBTN_Click_save;
        }



        private void CreateBTN_Click_save(object sender, EventArgs e)
        {
            if (this.nameBox.Text.Length > 0 && this.phoneBox.Text.Length > 0)
            {
                Controller.edit_save(this.nameBox.Text, this.lastNameBox.Text, this.phoneBox.Text, this.emailBox.Text, this.aboutBox.Text);
                clearInput();

                CreateBTN.Text = "Create";
                CreateBTN.Click -= CreateBTN_Click_save;
                CreateBTN.Click += CreateBTN_Click;
            }
            else
            {
                MessageBox.Show("Name and phone cann't be empty");
            }
            update();
        }

        private void clearInput()
        {
            nameBox.Text = "";
            lastNameBox.Text = "";
            phoneBox.Text = "";
            emailBox.Text = "";
            aboutBox.Text = "";

            textBoxSearch.Text = "";
        }

        private void CancelBTN_Click(object sender, EventArgs e)
        {
            clearInput();
            update();

            if (CreateBTN.Text.Equals("Save"))
            {
                CreateBTN.Text = "Create";
                CreateBTN.Click -= CreateBTN_Click_save;
                CreateBTN.Click += CreateBTN_Click;
            }
        }
    }
}
