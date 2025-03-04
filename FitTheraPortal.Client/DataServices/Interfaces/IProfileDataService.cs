using FitTheraPortal.Client.Dtos;

namespace FitTheraPortal.Client.DataServices.Interfaces;

public interface IProfileDataService
{
    Task<IEnumerable<ProfileDto>> GetProfilesAsync();
    Task<ProfileDto> GetProfileAsync(Guid id);
}