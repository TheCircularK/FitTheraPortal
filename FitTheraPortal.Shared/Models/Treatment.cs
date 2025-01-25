namespace FitTheraPortal.Shared.Models;

public class Treatment : Supabase.Postgrest.Models.BaseModel
{
    public int Id { get; set; }
    public string Type { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int InjuryId { get; set; }
}