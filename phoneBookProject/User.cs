using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneBookProject
{
    public class User
    {
        public User(int id, string name, string email, string phone, string lastName, string about)
        {
            this.Id = id;
            this.about = about;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
            this.LastName = lastName;
        }

        public int Id;
        public string Name;
        public string Email;
        public string Phone;
        public string LastName;
        public string about;
    }
}
