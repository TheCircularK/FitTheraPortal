using AutoMapper;
using FitTheraPortal.Server.Repositories;
using FitTheraPortal.Shared.Dtos;
using Profile = FitTheraPortal.Shared.Models.Profile;

namespace FitTheraPortal.Server.Services;

public class ProfileService : IProfileService
{
    private readonly IProfileRepository _repo;
    private readonly IMapper _mapper;

    public ProfileService(IProfileRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<ProfileDto>> GetAllAsync()
    {
        var profiles = await _repo.GetAllAsync();
        
        var response = _mapper.Map<IEnumerable<ProfileDto>>(profiles.ToList());

        return response;
    }

    public async Task<ProfileDto?> GetAsync(Guid id)
    {
        var profile = await _repo.GetByIdAsync(id);
        
        var response = _mapper.Map<ProfileDto>(profile);

        return response;
    }
}