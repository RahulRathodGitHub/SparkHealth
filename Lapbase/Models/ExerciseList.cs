using System;

namespace Lapbase.Models
{
    public class ExerciseList : TaskInput
    {
        public Guid[] Exercises { get; set; }
        public int[] Reps { get; set; }
    }
}
