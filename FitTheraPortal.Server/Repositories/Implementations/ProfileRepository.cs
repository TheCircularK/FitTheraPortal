using FitTheraPortal.Shared.Models;

namespace FitTheraPortal.Server.Repositories;

public class ProfileRepository : IProfileRepository
{
    private readonly Supabase.Client _client;
        
    public ProfileRepository(Supabase.Client client)
    {
        _client = client;
    }

    public async Task<IEnumerable<Profile>> GetAllAsync()
    {
        var response = await _client
            .From<Profile>()
            .Get();
            
        return response.Models;
    }

    public async Task<Profile?> GetByIdAsync(Guid id)
    {
        var response = await _client
            .From<Profile>()
            .Where(profile => profile.Id == id)
            .Get();
            
        return response.Models.FirstOrDefault();
    }

    public async Task CreateAsync(Profile profile)
    {
        await _client
            .From<Profile>()
            .Insert(profile);
            
        return;
    }

    public async Task<Profile> UpdateAsync(Profile profile)
    {
        await profile.Update<Profile>();
            
        return profile;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        await _client
            .From<Profile>()
            .Where(profile => profile.Id == id)
            .Delete();

        return true;
    }
}