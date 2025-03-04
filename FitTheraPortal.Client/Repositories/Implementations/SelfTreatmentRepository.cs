using FitTheraPortal.Client.Models;
using FitTheraPortal.Client.Repositories.Interfaces;

namespace FitTheraPortal.Client.Repositories.Implementations;

public class SelfTreatmentRepository : ISelfTreatmentRepository
{
    private readonly Supabase.Client _client;

    public SelfTreatmentRepository(Supabase.Client client)
    {
        _client = client;
    }

    public async Task<IEnumerable<SelfTreatment>> GetAllAsync()
    {
        var response = await _client
            .From<SelfTreatment>()
            .Get();

        return response.Models;
    }

    public async Task<SelfTreatment?> GetByIdAsync(Guid id)
    {
        var response = await _client
            .From<SelfTreatment>()
            .Where(selfTreatment => selfTreatment.Id == id)
            .Get();

        return response.Models.FirstOrDefault();
    }

    public async Task CreateAsync(SelfTreatment selfTreatment)
    {
        await _client
            .From<SelfTreatment>()
            .Insert(selfTreatment);
    }

    public async Task<SelfTreatment> UpdateAsync(SelfTreatment selfTreatment)
    {
        await selfTreatment.Update<SelfTreatment>();

        return selfTreatment;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        await _client
            .From<SelfTreatment>()
            .Where(selfTreatment => selfTreatment.Id == id)
            .Delete();

        return true;
    }
}