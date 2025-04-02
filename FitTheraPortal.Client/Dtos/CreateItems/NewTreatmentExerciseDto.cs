namespace FitTheraPortal.Client.Dtos.CreateItems;

public class NewTreatmentExerciseDto
{
    public Guid? ExerciseId { get; set; }
    public string? Title { get; set; }
    public int? ExerciseDuration { get; set; }
    public int? RestAfterSeconds { get; set; }
    public int? WeightLbs { get; set; }
    public int? Reps { get; set; }
}