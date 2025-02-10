using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace FitTheraPortal.Shared.Models;

[Table("Physical Therapist")]
public class PhysicalTherapist : BaseModel
{
    [PrimaryKey("Id", false)]
    public int Id { get; set; }
    
    [Column("first_name")]
    public string FirstName { get; set; }
    
    [Column("last_name")]
    public string LastName { get; set; }
    
    [Column("email")]
    public string Email { get; set; }
    
    [Column("company_id")]
    public int CompanyId { get; set; }
}