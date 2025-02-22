using FitTheraPortal.Shared.Models;

namespace FitTheraPortal.Server.Repositories;

public class ClinicRepository : IClinicRepository
{
    private readonly Supabase.Client _client;

    public ClinicRepository(Supabase.Client client)
    {
        _client = client;
    }

    public async Task<IEnumerable<Clinic>> GetAllAsync()
    {
        var response = await _client
            .From<Clinic>()
            .Get();

        return response.Models;
    }

    public async Task<Clinic?> GetByIdAsync(Guid id)
    {
        var response = await _client
            .From<Clinic>()
            .Where(clinic => clinic.Id == id)
            .Get();

        return response.Models.FirstOrDefault();
    }

    public async Task CreateAsync(Clinic clinic)
    {
        await _client
            .From<Clinic>()
            .Insert(clinic);
    }

    public async Task<Clinic> UpdateAsync(Clinic clinic)
    {
        await clinic.Update<Clinic>();

        return clinic;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        await _client
            .From<Clinic>()
            .Where(clinic => clinic.Id == id)
            .Delete();

        return true;
    }
}