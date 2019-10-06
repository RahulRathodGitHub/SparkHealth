using System;

namespace Lapbase.Models
{
    public class Exercise
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public int CalorieCount { get; set; }
        public string pictureUrl { get; set; }

    }
}
