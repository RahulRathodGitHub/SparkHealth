using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lapbase.Models
{
    public enum FeedbackType {
        Suggestion,
        IssueReport
    }

    public class Feedback
    {
        public Guid Id { get; set; }

        public DateTimeOffset Date { get; set; }
        public string content { get; set; }
        public FeedbackType Type { get; set; }

        public int PatientId { get; set; }
        public Patient Patient { get; set; }
    }
}
