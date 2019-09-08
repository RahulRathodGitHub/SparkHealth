using System;
using System.Collections.Generic;

namespace Lapbase.Models
{
    public class FoodIntakeList : TaskInput
    {
        public decimal Calories { get; set; }
        public decimal Weight { get; set; }
        public string Food { get; set; }
        public string Quantity { get; set; }
    }
}
