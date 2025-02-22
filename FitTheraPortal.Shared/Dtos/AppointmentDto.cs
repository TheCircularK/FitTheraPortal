using System;
using System.ComponentModel.DataAnnotations;

namespace FitTheraPortal.Shared.Dtos
{
    public class AppointmentDto
    {
        public Guid Id { get; set; }

        [Display(Name = "Therapist ID")]
        public Guid TherapistId { get; set; }

        [Display(Name = "Patient ID")]
        public Guid PatientId { get; set; }

        [Display(Name = "Notes")]
        public string Notes { get; set; }

        [Display(Name = "Created At")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Treatment Plan ID")]
        public Guid TreatmentPlanId { get; set; }

        [Display(Name = "Canceled")]
        public bool Canceled { get; set; }

        [Display(Name = "Accepted")]
        public bool Accepted { get; set; }

        [Display(Name = "Confirmed")]
        public bool Confirmed { get; set; }

        [Display(Name = "Start Time")]
        [DataType(DataType.DateTime)]
        public DateTime Start { get; set; }

        [Display(Name = "End Time")]
        [DataType(DataType.DateTime)]
        public DateTime End { get; set; }
    }
}