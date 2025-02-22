using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace FitTheraPortal.Shared.Models;

[Table("schedule")]
public class Schedule : BaseModel
{
    [PrimaryKey("Id")]
    public Guid Id { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("therapist_id")]
    public Guid TherapistId { get; set; }

    [Column("day_of_week")]
    public int DayOfWeek { get; set; }

    [Column("start_time")]
    public TimeSpan StartTime { get; set; }

    [Column("end_time")]
    public TimeSpan EndTime { get; set; }
}
