using FitTheraPortal.Client.Models;

namespace FitTheraPortal.Client.Repositories.Interfaces;

public interface IInjuryRepository
{
    Task<IEnumerable<Injury>> GetAllAsync();
    Task<Injury?> GetByIdAsync(Guid id);
    Task<IEnumerable<Injury>> GetByUserAsync(Guid userId);
    Task CreateAsync(Injury injury);
    Task<Injury> UpdateAsync(Injury injury);
    Task<bool> DeleteAsync(Guid id);
}