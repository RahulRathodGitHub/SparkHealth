using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.Models
{
    public class Advisor
    {
        public int Id { get; set; }

        public List<Patient> Patients { get; set; }
    }
}
