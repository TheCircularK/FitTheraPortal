using System.ComponentModel.DataAnnotations;

namespace FitTheraPortal.Client.Dtos
{
    public class ScheduleDto
    {
        public Guid Id { get; set; }

        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Therapist ID")]
        public Guid TherapistId { get; set; }

        [Display(Name = "Day of Week")]
        public int DayOfWeek { get; set; }

        [Display(Name = "Start Time")]
        public TimeSpan StartTime { get; set; }

        [Display(Name = "End Time")]
        public TimeSpan EndTime { get; set; }
    }
}