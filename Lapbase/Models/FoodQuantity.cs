using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.Models
{
    public class FoodQuantity
    {
        public String foodId { get; set; }
        public int quantity { get; set; }

        public FoodQuantity()
        {

        }

        public FoodQuantity(String foodId, int quantity)
        {
            this.foodId = foodId;
            this.quantity = quantity;

        }
    }
}
