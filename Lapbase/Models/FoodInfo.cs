using System;
using System.Collections.Generic;

namespace Lapbase.Models
{
    public class FoodInfo
    {
        public List<FoodQuantity> foods { get; set; }
        public IntakeTime intakeTime { get; set; }
        public String foodString { get; set; }
        public String quantityString { get; set; }

        public String getFoodString()
        {
            return foodString;
        }

        public String getQuantityString()
        {
            return quantityString;
        }


        public FoodInfo()
        {
        }

        public FoodInfo(String FoodNames, String Quantities, IntakeTime intakeTime)
        {
            this.foodString = FoodNames;
            this.quantityString = Quantities;

            String[] foodNames = FoodNames.Split(",");
            String[] quantities = Quantities.Split(",");
            foods = new List<FoodQuantity>();

            for (int i = 0; i < foodNames.Length; i++)
            {
                foods.Add(new FoodQuantity(foodNames[i], int.Parse(quantities[i])));
            }

            this.intakeTime = intakeTime;

        }

        public List<FoodQuantity> getFoods()
        {
            return this.foods;
        }

        public String getIntakeTimeString()
        {
            string intakeTimes = "";

            string thisIntake = this.intakeTime.ToString();

            foreach (FoodQuantity s in foods)
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
