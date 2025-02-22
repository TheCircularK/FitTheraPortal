using System;
using System.ComponentModel.DataAnnotations;

namespace FitTheraPortal.Shared.DTOs
{
    public class InjuryDto
    {
        public Guid Id { get; set; }

        [Display(Name = "Created At")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Injury Date")]
        [DataType(DataType.Date)]
        public DateTime InjuryDate { get; set; }

        [Display(Name = "Patient ID")]
        public Guid PatientId { get; set; }
    }
}