using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gestionale_Pizzeria.Models.Entity
{
    public abstract class Food
    {
        public string name { get; set; }
        public double price { get; set; }
        public List<string> ingredients { get; set; }

        public Food()
        {
            name = string.Empty;
            price = 0.00;
            ingredients = new List<string>();
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}