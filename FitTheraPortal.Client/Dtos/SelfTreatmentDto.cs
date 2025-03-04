using System.ComponentModel.DataAnnotations;

namespace FitTheraPortal.Client.Dtos
{
    public class SelfTreatmentDto
    {
        public Guid Id { get; set; }

        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Due Date")]
        public DateTime DueDate { get; set; }

        [Display(Name = "Complete")]
        public bool Complete { get; set; }

        [Display(Name = "Completed On")]
        public DateTime? CompletedOn { get; set; } // Nullable to allow for incomplete treatments

        [Display(Name = "Average Heart Rate")]
        public short AverageHeartRate { get; set; }

        [Display(Name = "Pain Difficulty")]
        public string PainDifficulty { get; set; }

        [Display(Name = "Treatment Plan ID")]
        public Guid TreatmentPlanId { get; set; }
    }
}