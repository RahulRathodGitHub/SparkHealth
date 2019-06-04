using System;
using System.Collections.Generic;

namespace Lapbase.Models
{
    public class FoodIntakeList : TaskInput
    {
        public string Food { get; set; }
        public string Quantity { get; set; }
    }
}
