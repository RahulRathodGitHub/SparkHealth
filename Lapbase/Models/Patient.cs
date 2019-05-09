using System;

namespace Lapbase.Models
{
    public class Patient
    {
        public Guid Id { get; set; }
        public int ExternalId { get; set; }

        public string UserName { get; set; }
        public DateTimeOffset? WhenCreated { get; set; }
    }
}
