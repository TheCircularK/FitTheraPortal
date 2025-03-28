namespace FitTheraPortal.Client.Dtos.CreateItems;

public class NewSelfTreatmentDto
{
    public NewSelfTreatmentDto()
    {
        Exercises = new HashSet<NewTreatmentExerciseDto>();
    }
    
    public string Title { get; set; }
    public DateTime DueDate { get; set; }
    
    public IEnumerable<NewTreatmentExerciseDto> Exercises { get; set; }
}