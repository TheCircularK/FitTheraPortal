using FitTheraPortal.Client.Models;

namespace FitTheraPortal.Client.Repositories.Interfaces;

public interface ISelfTreatmentRepository
{
    Task<IEnumerable<SelfTreatment>> GetAllAsync();
    Task<SelfTreatment?> GetByIdAsync(Guid id);
    Task CreateAsync(SelfTreatment selfTreatment);
    Task<SelfTreatment> UpdateAsync(SelfTreatment selfTreatment);
    Task<bool> DeleteAsync(Guid id);
}