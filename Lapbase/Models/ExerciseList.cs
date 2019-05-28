using System;
using System.Collections.Generic;

namespace Lapbase.Models
{
    public class ExerciseList : TaskInput
    {
        public ICollection<Exercise> Exercises { get; set; }
        // Reps = int[]
        public string Reps { get; set; }
    }
}
