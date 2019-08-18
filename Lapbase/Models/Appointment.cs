﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.Models
{

    public class Appointment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public int PatientId { get; set; }
        public string Description { get; set; }

    }

}