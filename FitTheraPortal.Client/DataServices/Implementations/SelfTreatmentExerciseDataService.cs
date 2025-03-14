using AutoMapper;
using FitTheraPortal.Client.DataServices.Interfaces;
using FitTheraPortal.Client.Dtos;
using FitTheraPortal.Client.Repositories.Interfaces;

namespace FitTheraPortal.Client.DataServices.Implementations;

public class SelfTreatmentExerciseDataService : ISelfTreatmentExerciseDataService
{
    private readonly ISelfTreatmentExerciseRepository _repo;
    private readonly IMapper _mapper;
    private readonly IExerciseDataService _exerciseDataService;
    private readonly IExerciseHealthDataDataService _exerciseHealthDataService;

    public SelfTreatmentExerciseDataService(ISelfTreatmentExerciseRepository repo, IMapper mapper, IExerciseDataService exerciseDataService, IExerciseHealthDataDataService exerciseHealthDataService)
    {
        _repo = repo;
        _mapper = mapper;
        _exerciseDataService = exerciseDataService;
        _exerciseHealthDataService = exerciseHealthDataService;
    }
    
    public async Task<IEnumerable<SelfTreatmentExerciseDto>> GetBySelfTreatmentIdAsync(Guid id)
    {
        var response = await _repo.GetBySelfTreatmentAsync(id);
        
        var mapped = _mapper.Map<IEnumerable<SelfTreatmentExerciseDto>>(response);

        mapped.Select(async item =>
        {
            item.Exercise = await _exerciseDataService.GetByIdAsync(item.ExerciseId);
            item.HealthData = await _exerciseHealthDataService.GetDataByExerciseAsync(item.Id);
        });

        return mapped;
    }
}