using FitTheraPortal.Shared.Models;

namespace FitTheraPortal.Server.Repositories;

public class TherapistRepository : ITherapistRepository
{
    private readonly Supabase.Client _client;

    public TherapistRepository(Supabase.Client client)
    {
        _client = client;
    }

    public async Task<IEnumerable<Therapist>> GetAllAsync()
    {
        var response = await _client
            .From<Therapist>()
            .Get();

        return response.Models;
    }

    public async Task<Therapist?> GetByIdAsync(Guid id)
    {
        var response = await _client
            .From<Therapist>()
            .Where(therapist => therapist.Id == id)
            .Get();

        return response.Models.FirstOrDefault();
    }

    public async Task CreateAsync(Therapist therapist)
    {
        await _client
            .From<Therapist>()
            .Insert(therapist);
    }

    public async Task<Therapist> UpdateAsync(Therapist therapist)
    {
        await therapist.Update<Therapist>();

        return therapist;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        await _client
            .From<Therapist>()
            .Where(therapist => therapist.Id == id)
            .Delete();

        return true;
    }
}