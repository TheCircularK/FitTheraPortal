using FitTheraPortal.Client.Dtos;

namespace FitTheraPortal.Client.DataServices.Interfaces;

public interface IExerciseDataService
{
    Task<ExerciseDto> GetByIdAsync(Guid id);
    
    Task<IEnumerable<ExerciseDto>> GetAllAsync();
}