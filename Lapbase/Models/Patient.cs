using System;
using System.Collections.Generic;

namespace Lapbase.Models
{
    public class Patient
    {
        public int Id { get; set; }

        public string Username { get; set; }
        public DateTimeOffset WhenCreated { get; set; }
        public DateTimeOffset ValidFrom { get; set; }
        public DateTimeOffset ValidTo { get; set; }
        public bool Deleted { get; set; }

        public int AdvisorId { get; set; }
        public Advisor Advisor { get; set; }

        // public ICollection<Food> Food { get; set; }
        // public ICollection<Exercise> Exercise { get; set; }
        // public ICollection<Feedback> Feedback { get; set; }
        // public ICollection<Task> Tasks { get; set; }
        // public ICollection<TaskInput> TaskInput { get; set; }
    }
}
