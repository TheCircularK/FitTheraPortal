using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace FitTheraPortal.Shared.Models;

[Table("patient")]
public class Patient : BaseModel
{
    [PrimaryKey("Id")]
    public Guid Id { get; set; }

    [Column("user_id")]
    public Guid UserId { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("current_conditions")]
    public string CurrentConditions { get; set; }

    [Column("activity_level")]
    public string ActivityLevel { get; set; }

    [Column("insurance_provider")]
    public string InsuranceProvider { get; set; }

    [Column("insurance_policy_no")]
    public string InsurancePolicyNo { get; set; }

    [Column("consent_forms")]
    public string ConsentForms { get; set; }

    [Column("emergency_contact")]
    public string EmergencyContact { get; set; }

    [Column("medical_history")]
    public string MedicalHistory { get; set; }
}
