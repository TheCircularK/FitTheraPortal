using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace FitTheraPortal.Shared.Models;

[Table("Injury")]
public class Injury : BaseModel
{
    [PrimaryKey("Id", false)]
    public int Id { get; set; }
    
    [Column("injury_name")]
    public string InjuryName { get; set; }
    
    [Column("patient_id")]
    public int PatientId { get; set; }
    
    [Column("therapist_id")]
    public int TherapistId { get; set; }
    
    [Column("injury_description")]
    public string InjuryDescription { get; set; }
    
    [Column("date_injured")]
    public DateTime DateInjured { get; set; }
    
    [Column("date_ok")]
    public DateTime DateOk { get; set; }
}