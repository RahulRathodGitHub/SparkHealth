using System;
using System.Collections.Generic;

namespace Lapbase.Models
{
    public class ExerciseList
    {
        public Guid Id { get; set; }
        public ICollection<Exercise> Exercises { get; set; }
        // Reps = int[]
        public string Reps { get; set; }

        //public IDictionary<Exercise,String> Exercises { get; set; }
    }
}
