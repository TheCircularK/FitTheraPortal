using FitTheraPortal.Client.Dtos;

namespace FitTheraPortal.Client.DataServices.Interfaces;

public interface IInjuryDataService
{
    Task<IEnumerable<InjuryDto>> GetInjuriesAsync();

    Task<InjuryDto> GetInjuryAsync(Guid id);
    Task<IEnumerable<InjuryDto>> GetByUserAsync(Guid userId);
}