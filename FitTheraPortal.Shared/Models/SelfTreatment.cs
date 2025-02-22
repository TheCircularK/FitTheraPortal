using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace FitTheraPortal.Shared.Models;

[Table("self-treatment")]
public class SelfTreatment : BaseModel
{
    [PrimaryKey("Id")]
    public Guid Id { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("title")]
    public string Title { get; set; }

    [Column("due_date")]
    public DateTime DueDate { get; set; }

    [Column("complete")]
    public bool Complete { get; set; }

    [Column("completed_on")]
    public DateTime? CompletedOn { get; set; } // Nullable to allow for incomplete treatments

    [Column("average_hearrate")]
    public short AverageHeartRate { get; set; }

    [Column("pain_difficulty")]
    public string PainDifficulty { get; set; }

    [Column("treatment_plan_id")]
    public Guid TreatmentPlanId { get; set; }
}