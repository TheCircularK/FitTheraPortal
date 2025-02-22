using System.ComponentModel.DataAnnotations;

namespace FitTheraPortal.Shared.Dtos
{
    public class TherapistDto
    {
        public Guid Id { get; set; }

        [Display(Name = "User ID")]
        public Guid UserId { get; set; }

        [Display(Name = "Clinic ID")]
        public Guid ClinicId { get; set; }

        [Display(Name = "Specialty")]
        public string? Specialty { get; set; }

        [Display(Name = "Add Code")]
        public string? AddCode { get; set; }

        [Display(Name = "Created At")]
        public DateTime CreatedAt { get; set; }
    }
}