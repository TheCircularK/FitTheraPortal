using System.ComponentModel;

namespace FitTheraPortal.Shared.Dtos;

public class CompanyDto
{
    public int Id { get; set; }
    
    [DisplayName("Company Name")]
    public string CompanyName { get; set; }

    [DisplayName("Street Address")]
    public string StreetAddress { get; set; }

    [DisplayName("Street Address 2")]
    public string StreetAddress2 { get; set; }

    [DisplayName("City")]
    public string City { get; set; }

    [DisplayName("State")]
    public string State { get; set; }

    [DisplayName("Zip Code")]
    public string ZipCode { get; set; }

    [DisplayName("Country")]
    public string Country { get; set; }

    [DisplayName("Phone Number")]
    public string PhoneNumber { get; set; }
}