using AutoMapper;
using FitTheraPortal.Client.DataServices.Interfaces;
using FitTheraPortal.Client.Dtos;
using FitTheraPortal.Client.Repositories.Interfaces;

namespace FitTheraPortal.Client.DataServices.Implementations;

public class ExerciseDataService : IExerciseDataService
{
    private readonly IExerciseRepository _exerciseRepository;
    private readonly IMapper _mapper;

    public ExerciseDataService(IExerciseRepository exerciseRepository, IMapper mapper)
    {
        _exerciseRepository = exerciseRepository;
        _mapper = mapper;
    }
    
    public async Task<ExerciseDto> GetByIdAsync(Guid id)
    {
        var response = await _exerciseRepository.GetByIdAsync(id);

        var mapped = _mapper.Map<ExerciseDto>(response);
        
        return mapped;
    }
}