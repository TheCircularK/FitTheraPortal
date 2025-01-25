namespace FitTheraPortal.Shared.Models;

public class Company
{
    public int Id { get; set; }
    public string CompanyName { get; set; }
    public string StreetAddress { get; set; }
    public string StreetAddress2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string PhoneNumber { get; set; }
    public int PatientID { get; set; }
}