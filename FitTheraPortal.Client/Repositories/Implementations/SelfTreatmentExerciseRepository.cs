using FitTheraPortal.Client.Models;
using FitTheraPortal.Client.Repositories.Interfaces;

namespace FitTheraPortal.Client.Repositories.Implementations;

public class SelfTreatmentExerciseRepository : ISelfTreatmentExerciseRepository
{
    private readonly Supabase.Client _client;

    public SelfTreatmentExerciseRepository(Supabase.Client client)
    {
        _client = client;
    }

    public async Task<IEnumerable<SelfTreatmentExercise>> GetAllAsync()
    {
        var response = await _client
            .From<SelfTreatmentExercise>()
            .Get();

        return response.Models;
    }

    public async Task<SelfTreatmentExercise?> GetByIdAsync(Guid id)
    {
        var response = await _client
            .From<SelfTreatmentExercise>()
            .Where(selfTreatmentExercise => selfTreatmentExercise.Id == id)
            .Get();

        return response.Models.FirstOrDefault();
    }

    public async Task CreateAsync(SelfTreatmentExercise selfTreatmentExercise)
    {
        await _client
            .From<SelfTreatmentExercise>()
            .Insert(selfTreatmentExercise);
    }

    public async Task<SelfTreatmentExercise> UpdateAsync(SelfTreatmentExercise selfTreatmentExercise)
    {
        await selfTreatmentExercise.Update<SelfTreatmentExercise>();

        return selfTreatmentExercise;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        await _client
            .From<SelfTreatmentExercise>()
            .Where(selfTreatmentExercise => selfTreatmentExercise.Id == id)
            .Delete();

        return true;
    }
}