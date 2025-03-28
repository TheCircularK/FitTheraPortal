namespace FitTheraPortal.Client.Dtos.CreateItems;

public class NewTreatmentPlanDto
{
    public NewTreatmentPlanDto()
    {
        SelfTreatments = new HashSet<NewSelfTreatmentDto>();
    }
    
    public Guid InjuryId { get; set; }
    public DateTime StartDate { get; set; } = DateTime.Now;
    public DateTime? EndDate { get; set; }
    public Guid TherapistId { get; set; }
    
    public IEnumerable<NewSelfTreatmentDto> SelfTreatments { get; set; }
}