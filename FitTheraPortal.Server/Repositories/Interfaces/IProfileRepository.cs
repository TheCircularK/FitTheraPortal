using FitTheraPortal.Shared.Models;

namespace FitTheraPortal.Server.Repositories;

public interface IProfileRepository
{
    Task<IEnumerable<Profile>> GetAllAsync();
    Task<Profile?> GetByIdAsync(Guid id);
    Task CreateAsync(Profile profile);
    Task<Profile> UpdateAsync(Profile profile);
    Task<bool> DeleteAsync(Guid id);
}