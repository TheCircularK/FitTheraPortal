using FitTheraPortal.Client.Dtos;
using FitTheraPortal.Client.Dtos.CreateItems;
using FitTheraPortal.Client.Models;

namespace FitTheraPortal.Client.DataServices.Interfaces;

public interface ISelfTreatmentDataService
{
    Task<SelfTreatmentDto> GetByIdAsync(Guid id);
    
    Task<IEnumerable<SelfTreatmentDto>> GetByTreatmentPlanAsync(Guid id);
    
    Task<Guid?> CreateAsync(SelfTreatment selfTreatment);
    
    Task AddSelfTreatmentToPlanAsync(NewSelfTreatmentDto selfTreatment, Guid treatmentPlanId);
}