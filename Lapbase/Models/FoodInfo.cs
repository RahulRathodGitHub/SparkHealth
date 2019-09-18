using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.Models
{
    public class FoodInfo
    {
        public String FoodNames { get; set; }
        public String Quantities { get; set; }
        public IntakeTime intakeTime { get; set; }

        public FoodInfo()
        {
        }

        public FoodInfo(String FoodNames, String Quantities, IntakeTime intakeTime)
        {
            this.FoodNames = FoodNames;
            this.Quantities = Quantities;
            this.intakeTime = intakeTime;

        }
    }

    public enum IntakeTime
    {
        BREAKFAST, LUNCH, DINNER
    }
}
