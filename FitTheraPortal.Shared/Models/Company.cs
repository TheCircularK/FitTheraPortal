using Supabase.Postgrest.Attributes;

namespace FitTheraPortal.Shared.Models;

[Table("Company")]
public class Company
{
    [PrimaryKey("Id", false)]
    public int Id { get; set; }
    
    [Column("company_name")]
    public string CompanyName { get; set; }
    
    [Column("street_address")]
    public string StreetAddress { get; set; }
    
    [Column("street_address2")]
    public string StreetAddress2 { get; set; }
    
    [Column("city")]
    public string City { get; set; }
    
    [Column("state")]
    public string State { get; set; }
    
    [Column("zip")]
    public string ZipCode { get; set; }
    
    [Column("country")]
    public string Country { get; set; }
    
    [Column("phone")]
    public string PhoneNumber { get; set; }
}