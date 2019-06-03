using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.Models
{
    public class TaskDto
    {
        public Guid Id { get; set; }
        public DateTimeOffset DueDate { get; set; }
        public TaskType Type { get; set; }
        public bool Completed { get; set; }
        public bool Overdue { get; set; }
        public int PatientId { get; set; }
        public int AdvisorId { get; set; }
    }

}
