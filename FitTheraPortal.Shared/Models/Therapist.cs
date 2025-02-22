using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace FitTheraPortal.Shared.Models;

[Table("therapist")]
public class Therapist : BaseModel
{
    [PrimaryKey("Id")]
    public Guid Id { get; set; }

    [Column("user_id")]
    public Guid UserId { get; set; }

    [Column("clinic_id")]
    public Guid ClinicId { get; set; }

    [Column("specialty")]
    public string? Specialty { get; set; }

    [Column("add_code")]
    public string? AddCode { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
}
