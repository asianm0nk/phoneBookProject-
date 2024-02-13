using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneBookProject
{
    internal class UserPanel : Panel
    {
        private Panel topPanel;
        private Button DeleteButton;
        private Button EditButton;
        private Label UserNameLabel;
        private Label phoneLabel;

        private Label name;
        private Label phone;
        private User user;

        public UserPanel(string userField, string userPhone, User user) {

            Height = 100;
            Width = 450;

            topPanel = new Panel
            {
                Parent = this,
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Fill,
                Height = 100,
                Width = 450
            };

            DeleteButton = new Button {
                Parent = topPanel,
                Location = new Point(292, 3),
                Text = "Delete",
                Height = 30

            };

            EditButton = new Button
            {
                Parent = topPanel,
                Location = new Point(292, 35),
                Text = "Edit",
                Height = 30
            };

            UserNameLabel = new Label
            {
                Parent = topPanel,
                Text = "Name",
                Location = new Point(0, 10)
            };

            phoneLabel = new Label
            {
                Parent = topPanel,
                Text = "phone",
                Location = new Point(0, 50)
            };

            name = new Label
            {
                Parent = topPanel,
                Text = userField,
                Location = new Point(0, 30)
            };

            phone = new Label
            {
                Parent = topPanel,
                Text = userPhone,
                Location = new Point(0, 70)
            };


            DeleteButton.Click += DeleteUser_Click;
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            this.Parent?.Controls.Remove(this);
        }
        //public string Name { get => UserName.Text; set => UserName.Text = value; }
        //public string Phone { get => phone.Text; set => phone.Text = value; }
    }

}
