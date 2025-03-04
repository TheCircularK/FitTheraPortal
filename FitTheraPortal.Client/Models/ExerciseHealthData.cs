using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace FitTheraPortal.Client.Models;

[Table("exercise-health-data")]
public class ExerciseHealthData : BaseModel
{
    [PrimaryKey("Id")]
    public Guid Id { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("exercise_id")]
    public Guid ExerciseId { get; set; }

    [Column("avg_heart_rate")]
    public int AvgHeartRate { get; set; }

    [Column("active_energy")]
    public long ActiveEnergy { get; set; }

    [Column("self_treatment_exercise_id")]
    public Guid SelfTreatmentExerciseId { get; set; }
}