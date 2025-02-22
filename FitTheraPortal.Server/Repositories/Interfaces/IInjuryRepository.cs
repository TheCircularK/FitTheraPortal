using FitTheraPortal.Shared.Models;

namespace FitTheraPortal.Server.Repositories;

public interface IInjuryRepository
{
    Task<IEnumerable<Injury>> GetAllAsync();
    Task<Injury?> GetByIdAsync(Guid id);
    Task CreateAsync(Injury injury);
    Task<Injury> UpdateAsync(Injury injury);
    Task<bool> DeleteAsync(Guid id);
}