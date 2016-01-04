using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Gestionale_Pizzeria.Models;
using Gestionale_Pizzeria.DAL;
using System.Web.Script.Serialization;
using System.Web.Security;


namespace Gestionale_Pizzeria.BusinessLogic
{
    public class UserAuthentification
    {
        private User user;

        public UserAuthentification(User user)
        {
          this.user = user;
        }


        public User authenticate()
        {
            try
            {
                if(DataUser.ExistsUser(user.userId))
                {
                    
                }
                else
                {
                   user.isOk = false;
                   user.messages.Add("Utente non esistente");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);                
            }

            return user;
        }

        private void SetCookie(bool persistent)
        {
            try
            {
                var serializer = new JavaScriptSerializer();
                string userData = serializer.Serialize(user);

                FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1,  //Guarda pure ki 
                    user.userId,
                    DateTime.Now,
                    DateTime.Now.AddDays(31), // value of time out property
                    persistent, // Value of IsPersistent property
                    userData,
                    FormsAuthentication.FormsCookiePath);
                string encTicket = FormsAuthentication.Encrypt(ticket);
                System.Web.HttpCookie authCookie = new System.Web.HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
                if (ticket.IsPersistent)
                {
                    authCookie.Expires = ticket.Expiration;
                }
                HttpContext.Current.Response.Cookies.Add(authCookie);
                HttpContext.Current.Items.Add("User", user);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}