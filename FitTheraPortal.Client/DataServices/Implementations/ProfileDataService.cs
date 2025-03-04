using System.Net.Http.Json;
using AutoMapper;
using FitTheraPortal.Client.DataServices.Interfaces;
using FitTheraPortal.Client.Dtos;
using FitTheraPortal.Client.Repositories;
using FitTheraPortal.Client.Repositories.Interfaces;

namespace FitTheraPortal.Client.DataServices.Implementations;

public class ProfileDataService : IProfileDataService
{
    private readonly IProfileRepository _profileRepository;
    private readonly IMapper _mapper;

    public ProfileDataService(IProfileRepository profileRepository, IMapper mapper)
    {
        _profileRepository = profileRepository;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<ProfileDto>> GetProfilesAsync()
    {
        var response = await _profileRepository.GetAllAsync();
        
        var mapped = _mapper.Map<IEnumerable<ProfileDto>>(response);

        return mapped;
    }

    public async Task<ProfileDto> GetProfileAsync(Guid id)
    {
        var response = await _profileRepository.GetByIdAsync(id);

        var mapped = _mapper.Map<ProfileDto>(response);

        return mapped;
    }
}