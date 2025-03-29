using FitTheraPortal.Client.Models;
using FitTheraPortal.Client.Repositories.Interfaces;
using Supabase.Postgrest;

namespace FitTheraPortal.Client.Repositories.Implementations;

public class InjuryTreatmentPlanRepository : IInjuryTreatmentPlanRepository
{
    private readonly Supabase.Client _client;

    public InjuryTreatmentPlanRepository(Supabase.Client client)
    {
        _client = client;
    }

    public async Task<IEnumerable<InjuryTreatmentPlan>> GetAllAsync()
    {
        var response = await _client
            .From<InjuryTreatmentPlan>()
            .Get();

        return response.Models;
    }

    public async Task<InjuryTreatmentPlan?> GetByIdAsync(Guid id)
    {
        var response = await _client
            .From<InjuryTreatmentPlan>()
            .Where(plan => plan.Id == id)
            .Get();

        return response.Models.FirstOrDefault();
    }

    public async Task<IEnumerable<InjuryTreatmentPlan>> GetByInjuryAsync(Guid injuryId)
    {
        var response = await _client
            .From<InjuryTreatmentPlan>()
            .Where(plan => plan.InjuryId == injuryId)
            .Get();
        
        return response.Models;
    }

    public async Task<Guid?> CreateAsync(InjuryTreatmentPlan plan)
    {
        var inserted = await _client
            .From<InjuryTreatmentPlan>()
            .Insert(plan, new QueryOptions { Returning = QueryOptions.ReturnType.Representation });

        return inserted?.Models?.FirstOrDefault()?.Id;
    }

    public async Task<InjuryTreatmentPlan> UpdateAsync(InjuryTreatmentPlan plan)
    {
        await plan.Update<InjuryTreatmentPlan>();

        return plan;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        await _client
            .From<InjuryTreatmentPlan>()
            .Where(plan => plan.Id == id)
            .Delete();

        return true;
    }
}