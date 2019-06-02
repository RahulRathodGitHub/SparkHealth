using System;

namespace Lapbase.Models
{
    public enum RepetitionType
    {
        Daily,
        Weekly,
        Monthly,
        Yearly
    }

    public enum TaskType
    {
        FoodIntakeInput,
        ExerciseInput
    }

    public class Task
    {
        public Guid Id { get; set; }

        public DateTimeOffset StartDate { get; set; }
        public RepetitionType Repetition { get; set; }
        public int RepetitionInterval { get; set; }
        public TaskType Type { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public int AdvisorId { get; set; }
        public Advisor Advisor { get; set; }
    }
}
