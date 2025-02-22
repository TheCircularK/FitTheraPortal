using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace FitTheraPortal.Shared.Models;

[Table("clinic")]
public class Clinic : BaseModel
{
    [PrimaryKey("Id")]
    public Guid Id { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("address")]
    public string Address { get; set; }

    [Column("phone")]
    public string Phone { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }
}