using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gestionale_Pizzeria.Models
{
    public class User : response
    {
        public string name;
        public string surname;
        public string userId;
        public string password;
        public string email;
        public string cellNumber;


        public User()
        {
            userId = string.Empty;
            password = string.Empty;
            name = string.Empty;
            surname = string.Empty;
            email = string.Empty;
            cellNumber = string.Empty;
        }

        public User(string userId, string password)
        {
            this.userId = userId;
            this.password = password;
        }

        public User(string userId, string password, string name, string surname, string email, string cellNumber)
        {
            this.userId = userId;
            this.password = password;
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.cellNumber = cellNumber;
        }

        public override string ToString()
        {
            return "nome utente:" + name + " " + surname;
        }
    }
}