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
        private Label UserName;
        private Label phone;

        public UserPanel() {

            Height = 100;
            Width = 450;

            //topPanel = new Panel {
            //    Parent = this,
            //    BorderStyle = BorderStyle.Fixed3D,
            //    Dock = DockStyle.Fill,
            //};
            //topPanel.Height = 100;
            //topPanel.Width = 450;

            UserName = new Label {
                Parent = this,
                Dock = DockStyle.Fill,
                
            };

            phone = new Label {
                Parent = this,
                Dock = DockStyle.Fill,
                Location = new Point(0, 54)
            };

            DeleteButton = new Button { 
                Parent = this,
                Location = new Point(292, 3) 
            };
        }

        public string Name { get => UserName.Text; set => UserName.Text = value; }
        public string Phone { get => phone.Text; set => phone.Text = value; }
    }

}
