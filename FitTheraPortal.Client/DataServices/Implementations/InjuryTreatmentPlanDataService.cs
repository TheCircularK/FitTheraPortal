using AutoMapper;
using FitTheraPortal.Client.DataServices.Interfaces;
using FitTheraPortal.Client.Dtos;
using FitTheraPortal.Client.Models;
using FitTheraPortal.Client.Repositories.Interfaces;

namespace FitTheraPortal.Client.DataServices.Implementations;

public class InjuryTreatmentPlanDataService : IInjuryTreatmentPlanDataService
{
    private readonly IMapper _mapper;
    private readonly IInjuryTreatmentPlanRepository _planRepository;
    private readonly ISelfTreatmentDataService _selfTreatmentDataService;

    public InjuryTreatmentPlanDataService(IMapper mapper, IInjuryTreatmentPlanRepository injuryRepository)
    {
        _mapper = mapper;
        _planRepository = injuryRepository;
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
}