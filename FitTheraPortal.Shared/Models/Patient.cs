namespace FitTheraPortal.Shared.Models;

public class Patient
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public int InjuryID { get; set; }
    public int EventID { get; set; }
}