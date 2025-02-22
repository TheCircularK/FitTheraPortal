using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace FitTheraPortal.Shared.Models;

[Table("exercise")]
public class Exercise : BaseModel
{
    [PrimaryKey("Id")]
    public Guid Id { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("name")]
    public string Name { get; set; }

    [Column("gif")]
    public string Gif { get; set; }
}