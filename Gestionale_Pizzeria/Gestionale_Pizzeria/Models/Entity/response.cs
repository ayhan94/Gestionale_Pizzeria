using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gestionale_Pizzeria.Models
{
    public class response
    {
        public bool isOk;
        public List<string> messages;

        public response()
        {
            isOk = true;
            messages = new List<string>(); ;
        }
    }
}