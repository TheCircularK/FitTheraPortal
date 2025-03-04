using FitTheraPortal.Client.Models;
using FitTheraPortal.Client.Repositories.Interfaces;

namespace FitTheraPortal.Client.Repositories.Implementations;

public class InjuryRepository : IInjuryRepository
{
    private readonly Supabase.Client _client;

    public InjuryRepository(Supabase.Client client)
    {
        _client = client;
    }

    public async Task<IEnumerable<Injury>> GetAllAsync()
    {
        var response = await _client
            .From<Injury>()
            .Get();

        return response.Models;
    }

    public async Task<Injury?> GetByIdAsync(Guid id)
    {
        var response = await _client
            .From<Injury>()
            .Where(injury => injury.Id == id)
            .Get();

        return response.Models.FirstOrDefault();
    }

    public async Task<IEnumerable<Injury>> GetByUserAsync(Guid userId)
    {
        var response = await _client
            .From<Injury>()
            .Where(injury => injury.PatientId == userId)
            .Get();
        
        return response.Models;
    }

    public async Task CreateAsync(Injury injury)
    {
        await _client
            .From<Injury>()
            .Insert(injury);
    }

    public async Task<Injury> UpdateAsync(Injury injury)
    {
        await injury.Update<Injury>();

        return injury;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        await _client
            .From<Injury>()
            .Where(injury => injury.Id == id)
            .Delete();

        return true;
    }
}