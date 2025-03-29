using FitTheraPortal.Client.Models;
using FitTheraPortal.Client.Repositories.Interfaces;
using Supabase.Postgrest;

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

    public async Task<Guid?> CreateAsync(SelfTreatment selfTreatment)
    {
        var inserted = await _client
            .From<SelfTreatment>()
            .Insert(selfTreatment, new QueryOptions { Returning = QueryOptions.ReturnType.Representation });

        return inserted?.Model?.Id;
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

    public async Task<IEnumerable<SelfTreatment>> GetByTreatmentPlanIdAsync(Guid id)
    {
        var response = await _client
            .From<SelfTreatment>()
            .Where(i => i.TreatmentPlanId == id)
            .Get();
        
        return response.Models;
    }
}