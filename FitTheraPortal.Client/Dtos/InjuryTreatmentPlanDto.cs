using System.ComponentModel.DataAnnotations;

namespace FitTheraPortal.Client.Dtos
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
        public int? OverallConfidenceScore { get; set; }

        [Display(Name = "Vertical Oscillation Score")]
        public int? VerticalOscillationScore { get; set; }

        [Display(Name = "Step Count Confidence Score")]
        public int? StepCountConfidenceScore { get; set; }

        [Display(Name = "Daily Activity Confidence Score")]
        public int? DailyActivityConfidenceScore { get; set; }

        [Display(Name = "Heart Rate Confidence Score")]
        public int? HeartRateConfidenceScore { get; set; }

        [Display(Name = "Stride Length Confidence Score")]
        public int? StrideLengthConfidenceScore { get; set; }

        [Display(Name = "Active")]
        public bool Active { get; set; }
        
        public IEnumerable<SelfTreatmentDto>? SelfTreatment { get; set; }
    }
}