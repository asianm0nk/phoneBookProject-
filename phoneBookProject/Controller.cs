using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace phoneBookProject
{
    internal class Controller 
    {
        Form1 form1;
        DBconnection dbconnection = new DBconnection();
        static User user;

        public Controller(Form1 form)
        {
            this.form1 = form;
        }
        
        public static List<UserPanel> getData(string orderBy)
        {
            List<UserPanel> data = new List<UserPanel>();
            var item = DBconnection.GetDataFromDB(orderBy);
            while (item.Read())
            {
                data.Add(new UserPanel(new User((int)item[0], (string)item[1], (string)item[4], (string)item[3], (string)item[2], (string)item[5])));
            }
            return data;
        }

        public static List<UserPanel> getData(NpgsqlDataReader reader)
        {
            List<UserPanel> data = new List<UserPanel>();
            var item = reader;
            while (item.Read())
            {
                data.Add(new UserPanel(new User((int)item[0], (string)item[1], (string)item[4], (string)item[3], (string)item[2], (string)item[5])));
            }
            return data;
        }

        private static bool IsDigitsOnlyCharMethod(string str) => str.All(char.IsDigit);


        public static void createUser(string name, string lastName, string phone, string email, string about)
        {
            if (IsDigitsOnlyCharMethod(phone) && phone.Length <= 10)
            {
                DBconnection.CreateUser(name, lastName, phone, email, about);
            }
            else
            {
                MessageBox.Show("phone number must contains only digits and be less then 10 digits");
            }
        }

        public static void deleteByID(Form1 form, int id)
        {
            DBconnection.DeleteByID(id);
            form.update();
        }

        public static void editById(Form1 form, User user)
        {
            form.EditUser(user);
            Controller.user = user;
        }

        public static void edit_save(string name, string lastname, string phone, string email, string about)
        {
            if (IsDigitsOnlyCharMethod(phone) && phone.Length <= 10)
            {
                user.about = about;
                user.Phone = phone;
                user.Email = email;
                user.Name = name;
                user.LastName = lastname;
                DBconnection.EditUserById(user);
            }
            else
            {
                MessageBox.Show("phone number must contains only digits and be less then 10 digits");
            }
            
        }
        
        public static List<UserPanel> search_user(string text, string orderBy)
        {
            string tmp = "";
            switch (SearchByTextSwitcher(text))
            {
                case "name":
                    tmp = text.Replace("name:", "");
                    return getData(DBconnection.SearchUsersByName(tmp, orderBy));
                case "lastname":
                    tmp = text.Replace("lastname:", "");
                    return getData(DBconnection.SearchUsersByLastName(tmp, orderBy));
                case "phone":
                    tmp = text.Replace("phone:", "");
                     return getData(DBconnection.SearchUsersByPhone(tmp, orderBy));

                default:
                    MessageBox.Show("incorrect search" +
                        "example name:yourname / phone:yourphone / lastname:yourLastName");
                    return null;
            }
        }

        private static string SearchByTextSwitcher(string text)
        {
            if (text.Contains("lastname:"))
            {
                return "lastname";
            }

            if (text.Contains("name:")) {
                return "name";
            }
                
            if (text.Contains("phone")) {                
                return "phone";
            }

            return null;
        }
    }
}
