using AutoMapper;
using FitTheraPortal.Client.DataServices.Interfaces;
using FitTheraPortal.Client.Dtos;
using FitTheraPortal.Client.Dtos.CreateItems;
using FitTheraPortal.Client.Models;
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

    public async Task<Guid?> CreateAsync(SelfTreatment selfTreatment)
    {
        var response = await _selfTreatmentRepository.CreateAsync(selfTreatment);

        return response;
    }

    public async Task AddSelfTreatmentToPlanAsync(NewSelfTreatmentDto selfTreatment, Guid treatmentPlanId)
    {
        await Task.Yield();
        
        var newSelfTreatmentId = Guid.NewGuid();
            
        var newSelfTreatment = new SelfTreatment()
        {
            Id = newSelfTreatmentId,
            Title = selfTreatment.Title,
            DueDate = selfTreatment.DueDate,
            TreatmentPlanId = (Guid)treatmentPlanId,
        };
            
        var selfTreatmentId = await CreateAsync(newSelfTreatment);

        // Add exercise objects -- use treatment plan ID
        foreach (var exercise in selfTreatment.Exercises)
        {
            var newExercise = new SelfTreatmentExercise
            {
                SelfTreatmentId = (Guid)selfTreatmentId,
                ExerciseId = (Guid)exercise.ExerciseId,
                ExerciseDuration = exercise.ExerciseDuration,
                RestAfterSeconds = exercise.RestAfterSeconds,
                WeightLbs = exercise.WeightLbs,
                Reps = exercise.Reps,
            };
                
            await _selfTreatmentExerciseDataService.CreateAsync(newExercise);
        }
    }
}