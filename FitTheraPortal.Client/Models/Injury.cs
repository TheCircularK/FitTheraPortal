using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace FitTheraPortal.Client.Models;

[Table("injury")]
public class Injury : BaseModel
{
    [PrimaryKey("Id")]
    public Guid Id { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("title")]
    public string Title { get; set; }

    [Column("description")]
    public string Description { get; set; }

    [Column("injury_date")]
    public DateTime InjuryDate { get; set; }

    [Column("patient_id")]
    public Guid PatientId { get; set; }
}
