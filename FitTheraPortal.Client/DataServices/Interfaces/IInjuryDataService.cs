using FitTheraPortal.Client.Dtos;
using FitTheraPortal.Client.Models;


namespace FitTheraPortal.Client.DataServices.Interfaces;


public interface IInjuryDataService
{
    Task<IEnumerable<InjuryDto>> GetInjuriesAsync();

    Task<InjuryDto> GetInjuryAsync(Guid id);
    Task<IEnumerable<InjuryDto>> GetByUserAsync(Guid userId);
    
    Task CreateAsync(InjuryDto injury);
}