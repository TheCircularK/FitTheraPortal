using FitTheraPortal.Client.Models;

namespace FitTheraPortal.Client.Repositories.Interfaces;

public interface IInjuryTreatmentPlanRepository
{
    Task<IEnumerable<InjuryTreatmentPlan>> GetAllAsync();
    Task<InjuryTreatmentPlan?> GetByIdAsync(Guid id);
    Task<IEnumerable<InjuryTreatmentPlan>> GetByInjuryAsync(Guid injuryId);
    Task CreateAsync(InjuryTreatmentPlan plan);
    Task<InjuryTreatmentPlan> UpdateAsync(InjuryTreatmentPlan plan);
    Task<bool> DeleteAsync(Guid id);
}