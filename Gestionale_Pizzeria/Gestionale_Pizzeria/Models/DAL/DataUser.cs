using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gestionale_Pizzeria.Models;

namespace Gestionale_Pizzeria.DAL
{
    public class DataUser
    {

        public static bool ExistsUser(string userId)
        {
            return true;
        }

        public static User GetUserByUserId(string userId)
        {
            User user = new User();

            try
            {

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            return user;
        }

        public static User GetUserByEmail(string email)
        {
            return new User();
        }
    }
}