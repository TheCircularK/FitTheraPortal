using FitTheraPortal.Client.Dtos;

namespace FitTheraPortal.Client.DataServices.Interfaces;

public interface IExerciseHealthDataDataService
{
    Task<IEnumerable<ExerciseHealthDataDto>> GetDataByExerciseAsync(Guid id);
}