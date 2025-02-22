using System;
using System.ComponentModel.DataAnnotations;

namespace FitTheraPortal.Shared.Dtos
{
    public class ExerciseDto
    {
        public Guid Id { get; set; }

        [Display(Name = "Created At")]
        [DataType(DataType.DateTime)]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Exercise Name")]
        public string Name { get; set; }

        [Display(Name = "GIF")]
        public string Gif { get; set; }
    }
}