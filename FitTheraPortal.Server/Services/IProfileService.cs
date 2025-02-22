using FitTheraPortal.Shared.Dtos;
using FitTheraPortal.Shared.Models;

namespace FitTheraPortal.Server.Services;

public interface IProfileService
{
    Task<IEnumerable<ProfileDto>> GetAllAsync();
    Task<ProfileDto?> GetAsync(Guid id);
}