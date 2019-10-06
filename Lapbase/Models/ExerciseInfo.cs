using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.Models
{
    public class ExerciseInfo
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; }

        public ExerciseInfo()
        {
        }

        public ExerciseInfo(Guid Id, int Quantity)
        {
            this.Id = Id;
            this.Quantity = Quantity;
        }

    }

}
