using System;

namespace Lapbase.Models
{
    public class Exercise
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public int CaloryCount { get; set; }
        public string pictureUrl { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
