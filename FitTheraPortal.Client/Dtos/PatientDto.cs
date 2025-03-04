using System.ComponentModel.DataAnnotations;

namespace FitTheraPortal.Client.Dtos
{
    public class PatientDto
    {
        public Guid Id { get; set; }

        [Display(Name = "User ID")]
        public Guid UserId { get; set; }

        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Current Conditions")]
        public string CurrentConditions { get; set; }

        [Display(Name = "Activity Level")]
        public string ActivityLevel { get; set; }

        [Display(Name = "Insurance Provider")]
        public string InsuranceProvider { get; set; }

        [Display(Name = "Insurance Policy Number")]
        public string InsurancePolicyNo { get; set; }

        [Display(Name = "Consent Forms")]
        public string ConsentForms { get; set; }

        [Display(Name = "Emergency Contact")]
        public string EmergencyContact { get; set; }

        [Display(Name = "Medical History")]
        public string MedicalHistory { get; set; }
        
        public ProfileDto? Profile { get; set; }
    }
}