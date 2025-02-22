using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace FitTheraPortal.Shared.Models;

[Table("injury-treatment-plan")]
public class InjuryTreatmentPlan : BaseModel
{
    [PrimaryKey("Id")]
    public Guid Id { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("injury_id")]
    public Guid InjuryId { get; set; }

    [Column("date_start")]
    public DateTime DateStart { get; set; }

    [Column("date_end")]
    public DateTime DateEnd { get; set; }

    [Column("overall_confidence_score")]
    public long OverallConfidenceScore { get; set; }

    [Column("vertical_ocillation_score")]
    public long VerticalOscillationScore { get; set; }

    [Column("step_count_confidence_score")]
    public long StepCountConfidenceScore { get; set; }

    [Column("daily_activity_confidence_score")]
    public long DailyActivityConfidenceScore { get; set; }

    [Column("heart_rate_confidence_score")]
    public long HeartRateConfidenceScore { get; set; }

    [Column("stride_length_confidence_score")]
    public long StrideLengthConfidenceScore { get; set; }

    [Column("active")]
    public bool Active { get; set; }
}