using System;

namespace Lapbase.Models
{
    public class FoodIntakeList : TaskInput
    {
        public Guid[] Food { get; set; }
        public int[] Quantity { get; set; }
    }
}
