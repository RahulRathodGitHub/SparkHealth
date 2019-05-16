using System;

namespace Lapbase.Models
{
    public class TaskInput
    {
        public Guid Id { get; set; }

        public DateTimeOffset DateEntered { get; set; }

        public Guid TaskId { get; set; }
        public Task Task { get; set; }
    }
}
