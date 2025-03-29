using FitTheraPortal.Client.Dtos;
using FitTheraPortal.Client.Models;

namespace FitTheraPortal.Client.DataServices.Interfaces;

public interface ISelfTreatmentDataService
{
    Task<SelfTreatmentDto> GetByIdAsync(Guid id);
    
    Task<IEnumerable<SelfTreatmentDto>> GetByTreatmentPlanAsync(Guid id);
    
    Task<Guid?> CreateAsync(SelfTreatment selfTreatment);
}