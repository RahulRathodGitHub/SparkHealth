using System;
using System.Collections.Generic;

namespace Lapbase.Models
{
    public class FoodIntakeList : TaskInput
    {
        public ICollection<Food> Food { get; set; }
        // Quantity = int[]
        public string Quantity { get; set; }
    }
}
