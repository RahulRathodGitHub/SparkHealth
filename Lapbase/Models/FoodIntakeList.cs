using System;
using System.Collections.Generic;

namespace Lapbase.Models
{
    public enum IntakeTime
    {
        BREAKFAST,
        LUNCH,
        DINNER
    }

    public class FoodIntakeList
    {
        public Guid Id { get; set; }
        public IntakeTime intakeTime { get; set; }
        public string Food { get; set; }
        public string Quantity { get; set; }
    }
}
