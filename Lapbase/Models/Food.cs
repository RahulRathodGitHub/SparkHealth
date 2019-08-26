using System;

namespace Lapbase.Models
{
    public class Food
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public int CalorieCount { get; set; }
        public string Unit { get; set; }
    }
}
