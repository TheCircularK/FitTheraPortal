using FitTheraPortal.Shared.Models;

namespace FitTheraPortal.Server.Repositories;

public interface IClinicRepository
{
    Task<IEnumerable<Clinic>> GetAllAsync();
    Task<Clinic?> GetByIdAsync(Guid id);
    Task CreateAsync(Clinic clinic);
    Task<Clinic> UpdateAsync(Clinic clinic);
    Task<bool> DeleteAsync(Guid id);
}