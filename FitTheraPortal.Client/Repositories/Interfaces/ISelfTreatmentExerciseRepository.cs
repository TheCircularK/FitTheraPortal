using FitTheraPortal.Client.Models;

namespace FitTheraPortal.Client.Repositories.Interfaces;

public interface ISelfTreatmentExerciseRepository
{
    Task<IEnumerable<SelfTreatmentExercise>> GetAllAsync();
    Task<SelfTreatmentExercise?> GetByIdAsync(Guid id);
    Task CreateAsync(SelfTreatmentExercise selfTreatmentExercise);
    Task<SelfTreatmentExercise> UpdateAsync(SelfTreatmentExercise selfTreatmentExercise);
    Task<bool> DeleteAsync(Guid id);
}