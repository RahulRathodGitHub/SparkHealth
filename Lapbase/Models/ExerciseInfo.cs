using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.Models
{
    public class ExerciseInfo
    {
        public String ExerciseNames { get; set; }
        public String Quantities { get; set; }

        public ExerciseInfo()
        {
        }

        public ExerciseInfo(String ExerciseNames, String Quantities)
        {
            this.ExerciseNames = ExerciseNames;
            this.Quantities = Quantities;
        }

        public String getExerciseString()
        {
            return ExerciseNames;
        }

        public String getExerciseReps()
        {
            return Quantities;
        }
    }

}
