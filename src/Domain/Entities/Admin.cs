using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Admin : User
    {

        public Admin() { }

        public Admin(string fullName, string email, string password) 
        {
            FullName = fullName;
            Email = email;
            Password = password;
            UserType UserRole = UserType.Admin;
        }
    }
}
