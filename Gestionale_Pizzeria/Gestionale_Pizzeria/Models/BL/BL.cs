using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gestionale_Pizzeria.Models;
using Gestionale_Pizzeria.DAL;

namespace Gestionale_Pizzeria.BusinessLogic
{
    public class BL
    {

        public static User AuthenticateUser(User user)
        {
            User userResponse = new User();

            try
            {
                UserAuthentification userAuthentification = new UserAuthentification(user);
                userResponse = userAuthentification.authenticate();

            }
            catch (Exception ex)
            {
                userResponse.isOk = false;
                userResponse.messages.Add("ATTENZIONE, errore durante l'autentificazione dell'utente: " + ex.Message);
            }

            return userResponse;
        }
    }
}