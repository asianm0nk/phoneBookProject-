using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phoneBookProject
{
    internal class User
    {
        public User(string name, string email, string phone, string lastName, string about)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Email = email ?? throw new ArgumentNullException(nameof(email));
            Phone = phone ?? throw new ArgumentNullException(nameof(phone));
            LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
            about = about ?? throw new ArgumentNullException(nameof(about));
        }

        public int Id;
        public string Name;
        public string Email;
        public string Phone;
        public string LastName;
        public string about;
    }
}
