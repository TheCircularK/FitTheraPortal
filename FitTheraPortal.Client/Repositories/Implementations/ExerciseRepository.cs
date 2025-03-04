using FitTheraPortal.Client.Models;
using FitTheraPortal.Client.Repositories.Interfaces;

namespace FitTheraPortal.Client.Repositories.Implementations;

public class ExerciseRepository : IExerciseRepository
{
    private readonly Supabase.Client _client;

    public ExerciseRepository(Supabase.Client client)
    {
        _client = client;
    }

    public async Task<IEnumerable<Exercise>> GetAllAsync()
    {
        var response = await _client
            .From<Exercise>()
            .Get();

        return response.Models;
    }

    public async Task<Exercise?> GetByIdAsync(Guid id)
    {
        var response = await _client
            .From<Exercise>()
            .Where(exercise => exercise.Id == id)
            .Get();

        return response.Models.FirstOrDefault();
    }

    public async Task CreateAsync(Exercise exercise)
    {
        await _client
            .From<Exercise>()
            .Insert(exercise);
    }

    public async Task<Exercise> UpdateAsync(Exercise exercise)
    {
        await exercise.Update<Exercise>();

        return exercise;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        await _client
            .From<Exercise>()
            .Where(exercise => exercise.Id == id)
            .Delete();

        return true;
    }
}