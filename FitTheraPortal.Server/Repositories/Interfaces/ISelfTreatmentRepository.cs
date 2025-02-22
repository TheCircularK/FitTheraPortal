using FitTheraPortal.Shared.Models;

namespace FitTheraPortal.Server.Repositories;

public interface ISelfTreatmentRepository
{
    Task<IEnumerable<SelfTreatment>> GetAllAsync();
    Task<SelfTreatment?> GetByIdAsync(Guid id);
    Task CreateAsync(SelfTreatment selfTreatment);
    Task<SelfTreatment> UpdateAsync(SelfTreatment selfTreatment);
    Task<bool> DeleteAsync(Guid id);
}