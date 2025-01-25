namespace FitTheraPortal.Shared.Models;

public class Injury
{
    public int Id { get; set; }
    public string InjuryName { get; set; }
    public int PatientID { get; set; }
    public int TherapistID { get; set; }
    public string InjuryDescription { get; set; }
}