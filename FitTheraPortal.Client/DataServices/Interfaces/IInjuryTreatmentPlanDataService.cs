using FitTheraPortal.Client.Dtos;
using FitTheraPortal.Client.Models;

namespace FitTheraPortal.Client.DataServices.Interfaces;

public interface IInjuryTreatmentPlanDataService
{
    Task<InjuryTreatmentPlanDto> GetAsync(Guid id);
    Task<IEnumerable<InjuryTreatmentPlanDto>> GetPlansByInjuryAsync(Guid injuryId);
}