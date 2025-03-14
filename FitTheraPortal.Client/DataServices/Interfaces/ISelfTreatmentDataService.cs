using FitTheraPortal.Client.Dtos;

namespace FitTheraPortal.Client.DataServices.Interfaces;

public interface ISelfTreatmentDataService
{
    Task<SelfTreatmentDto> GetByIdAsync(Guid id);
    
    Task<IEnumerable<SelfTreatmentDto>> GetByTreatmentPlanAsync(Guid id);
}