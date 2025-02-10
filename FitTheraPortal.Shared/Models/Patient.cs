using Supabase.Postgrest.Attributes;

namespace FitTheraPortal.Shared.Models;

[Table("Patient")]
public class Patient : Supabase.Postgrest.Models.BaseModel
{
    [PrimaryKey("Id", false)]
    public int Id { get; set; }
    
    [Column("first_name")]
    public string FirstName { get; set; }
    
    [Column("last_name")]
    public string LastName { get; set; }
    
    [Column("email")]
    public string? Email { get; set; }
    
    [Column("phone_number")]
    public string? PhoneNumber { get; set; }
}