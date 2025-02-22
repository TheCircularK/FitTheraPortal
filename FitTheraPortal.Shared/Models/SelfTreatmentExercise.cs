using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace FitTheraPortal.Shared.Models;

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
    public long ExerciseDuration { get; set; }

    [Column("rest_after_seconds")]
    public long RestAfterSeconds { get; set; }

    [Column("weight_lbs")]
    public long WeightLbs { get; set; }

    [Column("reps")]
    public long Reps { get; set; }
}
