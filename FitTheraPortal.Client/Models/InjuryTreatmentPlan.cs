using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace FitTheraPortal.Client.Models;

[Table("injury-treatment-plan")]
public class InjuryTreatmentPlan : BaseModel
{
    [PrimaryKey("id")]
    public Guid Id { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("injury_id")]
    public Guid InjuryId { get; set; }

    [Column("date_start")]
    public DateTime DateStart { get; set; }

    [Column("date_end")]
    public DateTime? DateEnd { get; set; }

    [Column("overall_confidence_score")]
    public int? OverallConfidenceScore { get; set; }

    [Column("vertical_ocillation_score")]
    public int? VerticalOscillationScore { get; set; }

    [Column("step_count_confidence_score")]
    public int? StepCountConfidenceScore { get; set; }

    [Column("daily_activity_confidence_score")]
    public int? DailyActivityConfidenceScore { get; set; }

    [Column("heart_rate_confidence_score")]
    public int? HeartRateConfidenceScore { get; set; }

    [Column("stride_length_confidence_score")]
    public int? StrideLengthConfidenceScore { get; set; }

    [Column("active")]
    public bool Active { get; set; }
    
    [Column("therapist_id")]
    public Guid TherapistId { get; set; }
}