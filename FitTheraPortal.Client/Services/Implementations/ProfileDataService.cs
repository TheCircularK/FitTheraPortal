using System.Net.Http.Json;
using FitTheraPortal.Shared.Dtos;

namespace FitTheraPortal.Client.Services;

public class ProfileDataService : IProfileDataService
{
    private readonly HttpClient _httpClient;

    public ProfileDataService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<IEnumerable<ProfileDto>> GetProfilesAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<IEnumerable<ProfileDto>>("api/profile");
        
        return response ?? [];
    }

    public Task<ProfileDto> GetProfileAsync(Guid id)
    {
        throw new NotImplementedException();
    }
}