using System.ComponentModel.DataAnnotations;

namespace FitTheraPortal.Client.Dtos
{
    public class ProfileDto
    {
        public ProfileDto(){}
        
        public Guid Id { get; set; }

        [Display(Name = "Updated At")]
        public DateTime UpdatedAt { get; set; }

        [Display(Name = "Username")]
        public string Username { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Avatar URL")]
        public string AvatarUrl { get; set; }

        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "State")]
        public string State { get; set; }

        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Birthdate")]
        public DateTime Birthdate { get; set; }
    }
}