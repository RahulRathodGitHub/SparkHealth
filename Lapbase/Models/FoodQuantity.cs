using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.Models
{
    public class FoodQuantity
    {
        public Guid Id { get; set; }
        public String name { get; set; }
        public double calories { get; set; }
        public int quantity { get; set; }

        public FoodQuantity()
        {

        }

        public FoodQuantity(String foodName, int quantity)
        {
            this.name = foodName;
            this.quantity = quantity;
            // What should we do about the calories.

        }
    }
}
