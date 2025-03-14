using AutoMapper;
using FitTheraPortal.Client.DataServices.Interfaces;
using FitTheraPortal.Client.Dtos;
using FitTheraPortal.Client.Repositories.Interfaces;

namespace FitTheraPortal.Client.DataServices.Implementations;

public class SelfTreatmentDataService : ISelfTreatmentDataService
{
    private readonly ISelfTreatmentRepository _selfTreatmentRepository;
    private readonly IMapper _mapper;
    private readonly ISelfTreatmentExerciseDataService _selfTreatmentExerciseDataService;

    public SelfTreatmentDataService(ISelfTreatmentRepository selfTreatmentRepository, IMapper mapper, ISelfTreatmentExerciseDataService selfTreatmentExerciseDataService)
    {
        _selfTreatmentRepository = selfTreatmentRepository;
        _mapper = mapper;
        _selfTreatmentExerciseDataService = selfTreatmentExerciseDataService;
    }
    
    public async Task<SelfTreatmentDto> GetByIdAsync(Guid id)
    {
        var response = await _selfTreatmentRepository.GetByIdAsync(id);
        
        var mapped = _mapper.Map<SelfTreatmentDto>(response);
        
        return mapped;
    }

    public async Task<IEnumerable<SelfTreatmentDto>> GetByTreatmentPlanAsync(Guid id)
    {
        var response = await _selfTreatmentRepository.GetByTreatmentPlanIdAsync(id);
        
        var mapped = _mapper.Map<IEnumerable<SelfTreatmentDto>>(response);

        mapped.Select(async item =>
        {
            item.SelfTreatmentExercises = await _selfTreatmentExerciseDataService.GetBySelfTreatmentIdAsync(item.Id);
        });
        
        return mapped;
    }
}