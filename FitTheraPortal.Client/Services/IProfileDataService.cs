using FitTheraPortal.Shared.Dtos;
using FitTheraPortal.Shared.Models;

namespace FitTheraPortal.Client.Services;

public interface IProfileDataService
{
    Task<IEnumerable<ProfileDto>> GetProfilesAsync();
    Task<ProfileDto> GetProfileAsync(Guid id);
}