using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace FitTheraPortal.Client.Models;

[Table("appointment")]
public class Appointment : BaseModel
{
    [PrimaryKey("id")]
    public Guid Id { get; set; }

    [Column("therapist_id")]
    public Guid TherapistId { get; set; }

    [Column("patient_id")]
    public Guid PatientId { get; set; }

    [Column("notes")]
    public string Notes { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("treatment_plan_id")]
    public Guid TreatmentPlanId { get; set; }

    [Column("canceled")]
    public bool Canceled { get; set; }

    [Column("accepted")]
    public bool Accepted { get; set; }

    [Column("confirmed")]
    public bool Confirmed { get; set; }

    [Column("start")]
    public DateTime Start { get; set; }

    [Column("end")]
    public DateTime End { get; set; }
}