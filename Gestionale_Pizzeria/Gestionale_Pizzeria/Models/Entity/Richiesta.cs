using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gestionale_Pizzeria.Models.Entity
{
    public class Request
    {
        List<Pizza> pizzas;
        List<Drink> drinks;

        public Request()
        {
            pizzas = new List<Pizza>();
            drinks = new List<Drink>();
        }
    }
}