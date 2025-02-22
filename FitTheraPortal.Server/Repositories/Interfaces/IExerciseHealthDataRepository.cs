using FitTheraPortal.Shared.Models;

namespace FitTheraPortal.Server.Repositories;

public interface IExerciseHealthDataRepository
{
    Task<IEnumerable<ExerciseHealthData>> GetAllAsync();
    Task<ExerciseHealthData?> GetByIdAsync(Guid id);
    Task CreateAsync(ExerciseHealthData exerciseHealthData);
    Task<ExerciseHealthData> UpdateAsync(ExerciseHealthData exerciseHealthData);
    Task<bool> DeleteAsync(Guid id);
}