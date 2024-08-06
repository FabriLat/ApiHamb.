using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Client : User
    {
        public List<Order> Orders { get; set; }

        public Client() { }

        public Client(string fullName, string email, string password)
        {
            FullName = fullName;
            Email = email;
            Password = password;
            Orders = new List<Order>();
            UserType UserRole = UserType.Client;
        }
    }
}
