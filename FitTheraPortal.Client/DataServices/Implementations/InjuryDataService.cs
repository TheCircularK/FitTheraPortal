using AutoMapper;
using FitTheraPortal.Client.DataServices.Interfaces;
using FitTheraPortal.Client.Dtos;
using FitTheraPortal.Client.Repositories.Interfaces;

namespace FitTheraPortal.Client.DataServices.Implementations;

public class InjuryDataService : IInjuryDataService
{
    private readonly IInjuryRepository _injuryRepository;
    private readonly IMapper _mapper;
    private readonly IInjuryTreatmentPlanDataService _planDataService;

    public InjuryDataService(IInjuryRepository injuryRepository, IMapper mapper, IInjuryTreatmentPlanDataService planDataService)
    {
        _injuryRepository = injuryRepository;
        _mapper = mapper;
        _planDataService = planDataService;
    }
    
    public async Task<IEnumerable<InjuryDto>> GetInjuriesAsync()
    {
        var response = await _injuryRepository.GetAllAsync();
        var mapped = _mapper.Map<IEnumerable<InjuryDto>>(response);
        return mapped;
    }

    public async Task<InjuryDto> GetInjuryAsync(Guid id)
    {
        var response = await _injuryRepository.GetByIdAsync(id);
        var mapped = _mapper.Map<InjuryDto>(response);
        return mapped;
    }

    public async Task<IEnumerable<InjuryDto>> GetByUserAsync(Guid userId)
    {
        var response = await _injuryRepository.GetByUserAsync(userId);
        var mapped = _mapper.Map<IEnumerable<InjuryDto>>(response);

        var tasks = mapped.Select(async injury =>
        {
            injury.TreatmentPlans = await _planDataService.GetPlansByInjuryAsync(injury.Id);
        });
        
        await Task.WhenAll(tasks);

        mapped.OrderByDescending(i => i.InjuryDate);
        
        return mapped;
    }
}