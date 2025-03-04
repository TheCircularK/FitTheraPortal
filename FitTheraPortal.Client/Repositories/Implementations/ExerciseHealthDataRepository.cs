using FitTheraPortal.Client.Models;
using FitTheraPortal.Client.Repositories.Interfaces;

namespace FitTheraPortal.Client.Repositories.Implementations;

public class ExerciseHealthDataRepository : IExerciseHealthDataRepository
{
    private readonly Supabase.Client _client;

    public ExerciseHealthDataRepository(Supabase.Client client)
    {
        _client = client;
    }

    public async Task<IEnumerable<ExerciseHealthData>> GetAllAsync()
    {
        var response = await _client
            .From<ExerciseHealthData>()
            .Get();

        return response.Models;
    }

    public async Task<ExerciseHealthData?> GetByIdAsync(Guid id)
    {
        var response = await _client
            .From<ExerciseHealthData>()
            .Where(data => data.Id == id)
            .Get();

        return response.Models.FirstOrDefault();
    }

    public async Task CreateAsync(ExerciseHealthData exerciseHealthData)
    {
        await _client
            .From<ExerciseHealthData>()
            .Insert(exerciseHealthData);
    }

    public async Task<ExerciseHealthData> UpdateAsync(ExerciseHealthData exerciseHealthData)
    {
        await exerciseHealthData.Update<ExerciseHealthData>();

        return exerciseHealthData;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        await _client
            .From<ExerciseHealthData>()
            .Where(data => data.Id == id)
            .Delete();

        return true;
    }
}