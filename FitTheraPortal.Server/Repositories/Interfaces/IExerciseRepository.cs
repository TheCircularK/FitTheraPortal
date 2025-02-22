using FitTheraPortal.Shared.Models;

namespace FitTheraPortal.Server.Repositories;

public interface IExerciseRepository
{
    Task<IEnumerable<Exercise>> GetAllAsync();
    Task<Exercise?> GetByIdAsync(Guid id);
    Task CreateAsync(Exercise exercise);
    Task<Exercise> UpdateAsync(Exercise exercise);
    Task<bool> DeleteAsync(Guid id);
}