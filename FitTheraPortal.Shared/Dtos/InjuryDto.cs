using System.ComponentModel;

namespace FitTheraPortal.Shared.Dtos;

public class InjuryDto
{
    public InjuryDto(){ }
    
    public int Id { get; set; }
    
    [DisplayName("Injury Name")]
    public string InjuryName { get; set; }

    [DisplayName("Patient ID")]
    public int PatientId { get; set; }

    [DisplayName("Therapist ID")]
    public int TherapistId { get; set; }

    [DisplayName("Injury Description")]
    public string? InjuryDescription { get; set; }

    [DisplayName("Date Injured")]
    public DateTime? DateInjured { get; set; }

    [DisplayName("Date OK")]
    public DateTime? DateOk { get; set; }
}