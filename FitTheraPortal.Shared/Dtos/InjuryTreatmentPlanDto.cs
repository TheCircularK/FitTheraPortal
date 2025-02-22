using System;
using System.ComponentModel.DataAnnotations;

namespace FitTheraPortal.Shared.Dtos
{
    public class InjuryTreatmentPlanDto
    {
        public Guid Id { get; set; }

        [Display(Name = "Created At")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Injury ID")]
        public Guid InjuryId { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime DateStart { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime DateEnd { get; set; }

        [Display(Name = "Overall Confidence Score")]
        public long OverallConfidenceScore { get; set; }

        [Display(Name = "Vertical Oscillation Score")]
        public long VerticalOscillationScore { get; set; }

        [Display(Name = "Step Count Confidence Score")]
        public long StepCountConfidenceScore { get; set; }

        [Display(Name = "Daily Activity Confidence Score")]
        public long DailyActivityConfidenceScore { get; set; }

        [Display(Name = "Heart Rate Confidence Score")]
        public long HeartRateConfidenceScore { get; set; }

        [Display(Name = "Stride Length Confidence Score")]
        public long StrideLengthConfidenceScore { get; set; }

        [Display(Name = "Active")]
        public bool Active { get; set; }
    }
}