using System;
using System.ComponentModel.DataAnnotations;

namespace FitTheraPortal.Shared.Dtos
{
    public class SelfTreatmentExerciseDto
    {
        public Guid Id { get; set; }

        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Self Treatment ID")]
        public Guid SelfTreatmentId { get; set; }

        [Display(Name = "Exercise ID")]
        public Guid ExerciseId { get; set; }

        [Display(Name = "Exercise Duration (seconds)")]
        public long ExerciseDuration { get; set; }

        [Display(Name = "Rest After (seconds)")]
        public long RestAfterSeconds { get; set; }

        [Display(Name = "Weight (lbs)")]
        public long WeightLbs { get; set; }

        [Display(Name = "Reps")]
        public long Reps { get; set; }
    }
}