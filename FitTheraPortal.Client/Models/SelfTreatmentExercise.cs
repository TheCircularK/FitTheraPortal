using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace FitTheraPortal.Client.Models;

[Table("self-treatment-exercise")]
public class SelfTreatmentExercise : BaseModel
{
    [PrimaryKey("Id")]
    public Guid Id { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("self_treatment_id")]
    public Guid SelfTreatmentId { get; set; }

    [Column("exercise_id")]
    public Guid ExerciseId { get; set; }

    [Column("exercise_duration")]
    public int? ExerciseDuration { get; set; }

    [Column("rest_after_seconds")]
    public int? RestAfterSeconds { get; set; }

    [Column("weight_lbs")]
    public int? WeightLbs { get; set; }

    [Column("reps")]
    public int? Reps { get; set; }
}
