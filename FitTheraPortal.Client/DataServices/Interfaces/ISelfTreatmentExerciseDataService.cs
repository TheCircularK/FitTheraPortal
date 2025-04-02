using FitTheraPortal.Client.Dtos;
using FitTheraPortal.Client.Models;

namespace FitTheraPortal.Client.DataServices.Interfaces;

public interface ISelfTreatmentExerciseDataService
{
    Task<IEnumerable<SelfTreatmentExerciseDto>> GetBySelfTreatmentIdAsync(Guid id);
    
    Task CreateAsync(SelfTreatmentExercise selfTreatmentExercise);
}