using FitTheraPortal.Client.Models;

namespace FitTheraPortal.Client.Repositories.Interfaces;

public interface IExerciseHealthDataRepository
{
    Task<IEnumerable<ExerciseHealthData>> GetAllAsync();
    Task<ExerciseHealthData?> GetByIdAsync(Guid id);
    Task CreateAsync(ExerciseHealthData exerciseHealthData);
    Task<ExerciseHealthData> UpdateAsync(ExerciseHealthData exerciseHealthData);
    Task<bool> DeleteAsync(Guid id);
}