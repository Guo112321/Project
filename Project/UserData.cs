using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class UserData
    {
        public string Firstname { get; set; }
        public string Lastname {  get; set; }
        public string Email { get; set; }
        public string PhoneNo { get; set; }
        public string Password { get; set; }

        public bool IsAdmin { get; set; }

        public UserData(string FirstName, string Lastname, string Email, string PhoneNo, string Password, bool IsAdmin)
        {
            this.Firstname = FirstName;
            this.Lastname = Lastname;
            this.Email = Email;
            this.PhoneNo = PhoneNo;
            this.Password = Password;
            this.IsAdmin = IsAdmin;
        }
    }
}