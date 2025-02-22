using Supabase.Postgrest.Attributes;
using Supabase.Postgrest.Models;

namespace FitTheraPortal.Shared.Models;

[Table("profile")]
public class Profile : BaseModel
{
    [PrimaryKey("Id")]
    public Guid Id { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [Column("username")]
    public string Username { get; set; }

    [Column("first_name")]
    public string FirstName { get; set; }

    [Column("last_name")]
    public string LastName { get; set; }

    [Column("avatar_url")]
    public string AvatarUrl { get; set; }

    [Column("street_address")]
    public string StreetAddress { get; set; }

    [Column("city")]
    public string City { get; set; }

    [Column("state")]
    public string State { get; set; }

    [Column("zip_code")]
    public string ZipCode { get; set; }

    [Column("phone_number")]
    public string PhoneNumber { get; set; }

    [Column("email")]
    public string Email { get; set; }

    [Column("gender")]
    public string Gender { get; set; }

    [Column("birthdate")]
    public DateTime Birthdate { get; set; }
}