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

        public String getFoodString()
        {
            return FoodNames;
        }

        public String getFoodQuantityString()
        {
            return Quantities;
        }

        public String getIntakeTimeString()
        {
            string intakeTimes = "";

            string thisIntake = this.intakeTime.ToString();

            foreach(string s in FoodNames.Split(","))
            {
                intakeTimes += "," + thisIntake;
            }

            return intakeTimes.Substring(1);
        }
    }

    public enum IntakeTime
    {
        BREAKFAST, LUNCH, DINNER
    }
}
