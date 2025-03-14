using FitTheraPortal.Client.Dtos;

namespace FitTheraPortal.Client.DataServices.Interfaces;

public interface ISelfTreatmentExerciseDataService
{
    Task<IEnumerable<SelfTreatmentExerciseDto>> GetBySelfTreatmentIdAsync(Guid id);
}