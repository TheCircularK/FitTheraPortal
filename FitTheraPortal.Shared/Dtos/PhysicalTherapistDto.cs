using System.ComponentModel;

namespace FitTheraPortal.Shared.Dtos;

public class PhysicalTherapistDto
{
    [DisplayName("First Name")]
    public string FirstName { get; set; }

    [DisplayName("Last Name")]
    public string LastName { get; set; }

    [DisplayName("Email")]
    public string Email { get; set; }
}