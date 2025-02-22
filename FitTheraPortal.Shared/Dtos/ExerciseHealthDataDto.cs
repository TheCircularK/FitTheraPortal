using System;
using System.ComponentModel.DataAnnotations;

namespace FitTheraPortal.Shared.Dtos
{
    public class ExerciseHealthDataDto
    {
        public long Id { get; set; }

        [Display(Name = "Created At")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Exercise ID")]
        public Guid ExerciseId { get; set; }

        [Display(Name = "Average Heart Rate")]
        public int AvgHeartRate { get; set; }

        [Display(Name = "Active Energy")]
        public long ActiveEnergy { get; set; }

        [Display(Name = "Self Treatment Exercise ID")]
        public Guid SelfTreatmentExerciseId { get; set; }
    }
}