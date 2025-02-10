using System.ComponentModel;

namespace FitTheraPortal.Shared.Dtos;

public class TreatmentDto
{
    public int Id { get; set; }
    
    [DisplayName("Type")]
    public string Type { get; set; }

    [DisplayName("Start Date")]
    public DateTime StartDate { get; set; }

    [DisplayName("End Date")]
    public DateTime EndDate { get; set; }
}