namespace FitTheraPortal.Client.Dtos.CreateItems;

public class NewSelfTreatmentDto
{
    public NewSelfTreatmentDto()
    {
        Exercises = new List<NewTreatmentExerciseDto>();
    }
    
    public string Title { get; set; }
    public DateTime DueDate { get; set; }
    
    public IList<NewTreatmentExerciseDto> Exercises { get; set; }
}