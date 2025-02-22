using FitTheraPortal.Shared.Models;

namespace FitTheraPortal.Server.Repositories;

public interface IInjuryTreatmentPlanRepository
{
    Task<IEnumerable<InjuryTreatmentPlan>> GetAllAsync();
    Task<InjuryTreatmentPlan?> GetByIdAsync(Guid id);
    Task CreateAsync(InjuryTreatmentPlan plan);
    Task<InjuryTreatmentPlan> UpdateAsync(InjuryTreatmentPlan plan);
    Task<bool> DeleteAsync(Guid id);
}