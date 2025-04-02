using AutoMapper;
using FitTheraPortal.Client.DataServices.Interfaces;
using FitTheraPortal.Client.Dtos;
using FitTheraPortal.Client.Dtos.CreateItems;
using FitTheraPortal.Client.Models;
using FitTheraPortal.Client.Repositories.Interfaces;

namespace FitTheraPortal.Client.DataServices.Implementations;

public class InjuryTreatmentPlanDataService : IInjuryTreatmentPlanDataService
{
    private readonly IMapper _mapper;
    private readonly IInjuryTreatmentPlanRepository _planRepository;
    private readonly ISelfTreatmentDataService _selfTreatmentDataService;
    private readonly ISelfTreatmentExerciseDataService _selfTreatmentExerciseDataService;

    public InjuryTreatmentPlanDataService(IMapper mapper, IInjuryTreatmentPlanRepository injuryRepository, ISelfTreatmentDataService selfTreatmentDataService, ISelfTreatmentExerciseDataService selfTreatmentExerciseDataService)
    {
        _mapper = mapper;
        _planRepository = injuryRepository;
        _selfTreatmentDataService = selfTreatmentDataService;
        _selfTreatmentExerciseDataService = selfTreatmentExerciseDataService;
    }

    public async Task<InjuryTreatmentPlanDto> GetAsync(Guid id)
    {
        var response = await _planRepository.GetByIdAsync(id);
        
        var mapped = _mapper.Map<InjuryTreatmentPlanDto>(response);
        
        mapped.SelfTreatment = await _selfTreatmentDataService.GetByTreatmentPlanAsync(mapped.Id);
        
        return mapped;
    }
    public async Task<IEnumerable<InjuryTreatmentPlanDto>> GetPlansByInjuryAsync(Guid injuryId)
    {
        // Get plans
        var response = await _planRepository.GetByInjuryAsync(injuryId);
        
        var mapped = _mapper.Map<IEnumerable<InjuryTreatmentPlanDto>>(response);
        
        mapped.OrderByDescending(i => i.CreatedAt);
        
        // Get self treatment
        mapped.Select(async t =>
        {
            t.SelfTreatment = await _selfTreatmentDataService.GetByTreatmentPlanAsync(t.Id);
        });
        
        return mapped;
    }

    public Task Create(InjuryTreatmentPlan newPlan)
    {
        return _planRepository.CreateAsync(newPlan);
    }

    public async Task AddNewTreatmentPlanAsync(NewTreatmentPlanDto plan)
    {
        // Make treatment plan -- get ID
        var treatmentPlanGuid = Guid.NewGuid();
        
        var newTreatmentPlan = new InjuryTreatmentPlan()
        {
            InjuryId = plan.InjuryId,
            DateStart = plan.StartDate,
            DateEnd = plan.EndDate,
            Active = true,
            TherapistId = plan.TherapistId,
            Id = treatmentPlanGuid,
        };
        
        var treatmentPlanId = await _planRepository.CreateAsync(newTreatmentPlan);

        // Make self treatments -- use treatment plan ID
        foreach (var treatment in plan.SelfTreatments)
        {
            var newSelfTreatmentId = Guid.NewGuid();
            
            var newSelfTreatment = new SelfTreatment()
            {
                Id = newSelfTreatmentId,
                Title = treatment.Title,
                DueDate = treatment.DueDate,
                TreatmentPlanId = (Guid)treatmentPlanId,
            };
            
            var selfTreatmentId = await _selfTreatmentDataService.CreateAsync(newSelfTreatment);

            // Add exercise objects -- use treatment plan ID
            foreach (var exercise in treatment.Exercises)
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
}