using System.ComponentModel;

namespace FitTheraPortal.Shared.Dtos;

public class PatientDto
{
    public int Id { get; set; }
    
    [DisplayName("First Name")]
    public string FirstName { get; set; }

    [DisplayName("Last Name")]
    public string LastName { get; set; }

    [DisplayName("Email")]
    public string? Email { get; set; }

    [DisplayName("Phone Number")]
    public string? PhoneNumber { get; set; }
}