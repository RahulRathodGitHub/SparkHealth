using System.Collections.Generic;

namespace Lapbase.Models
{
    public class FoodInfo
    {
        public List<FoodQuantity> Foods { get; set; }
        public MealTime MealTime { get; set; }
    }

    public enum MealTime
    {
        BREAKFAST, LUNCH, DINNER
    }
}
