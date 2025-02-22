using System;
using System.ComponentModel.DataAnnotations;

namespace FitTheraPortal.Shared.DTOs
{
    public class ClinicDto
    {
        public Guid Id { get; set; }

        [Display(Name = "Clinic Name")]
        public string Name { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Display(Name = "Created At")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }
    }
}