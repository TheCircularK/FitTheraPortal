using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace FitTheraPortal.Shared.Models;

[Table("treatment")]
public class Treatment : BaseModel
{
    [PrimaryKey("id", false)]
    public int Id { get; set; }
    
    [Column("type")]
    public string Type { get; set; }
    
    [Column("start_date")]
    public DateTime StartDate { get; set; }
    
    [Column("end_date")]
    public DateTime EndDate { get; set; }
    
    [Column("injury_id")]
    public int InjuryId { get; set; }
}