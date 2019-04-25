using System;

namespace Lapbase.Models
{
    public class Patient
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public DateTimeOffset WhenCreated { get; set; }
    }
}
