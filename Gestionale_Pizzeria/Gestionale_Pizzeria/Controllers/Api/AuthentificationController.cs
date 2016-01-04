using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Gestionale_Pizzeria.Models;
using Gestionale_Pizzeria.BusinessLogic;

namespace Gestionale_Pizzeria.Controllers.Api
{
    public class AuthentificationController : ApiController
    {

        // POST: api/Authentification
        [HttpPost]
        public response Authenticate([FromBody]User user)
        {
            return BL.AuthenticateUser(user);
            
        }
       
    }
}
