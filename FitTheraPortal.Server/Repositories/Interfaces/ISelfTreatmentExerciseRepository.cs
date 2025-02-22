using FitTheraPortal.Shared.Models;

namespace FitTheraPortal.Server.Repositories;

public interface ISelfTreatmentExerciseRepository
{
    Task<IEnumerable<SelfTreatmentExercise>> GetAllAsync();
    Task<SelfTreatmentExercise?> GetByIdAsync(Guid id);
    Task CreateAsync(SelfTreatmentExercise selfTreatmentExercise);
    Task<SelfTreatmentExercise> UpdateAsync(SelfTreatmentExercise selfTreatmentExercise);
    Task<bool> DeleteAsync(Guid id);
}