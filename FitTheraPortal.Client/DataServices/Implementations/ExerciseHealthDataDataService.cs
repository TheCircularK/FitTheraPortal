using FitTheraPortal.Client.DataServices.Interfaces;
using FitTheraPortal.Client.Dtos;
using FitTheraPortal.Client.Models;
using FitTheraPortal.Client.Repositories.Interfaces;

namespace FitTheraPortal.Client.DataServices.Implementations;

public class ExerciseHealthDataDataService : IExerciseHealthDataDataService
{
    private readonly IExerciseHealthDataRepository _repo;

    public ExerciseHealthDataDataService(IExerciseHealthDataRepository repo)
    {
        _repo = repo;
    }

    public async Task<IEnumerable<ExerciseHealthDataDto>> GetDataByExerciseAsync(Guid id)
    {
        await Task.Yield();
        
        return new List<ExerciseHealthDataDto>();
    }
}