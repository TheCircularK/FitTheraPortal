using System.Net.Http.Json;
using AutoMapper;
using FitTheraPortal.Client.DataServices.Interfaces;
using FitTheraPortal.Client.Dtos;
using FitTheraPortal.Client.Repositories;
using FitTheraPortal.Client.Repositories.Interfaces;

namespace FitTheraPortal.Client.DataServices.Implementations;

public class PatientDataService : IPatientDataService
{
    private readonly IPatientRepository _patientRepository;
    private readonly IMapper _mapper;
    private readonly IProfileDataService _profileDataService;

    public PatientDataService(IPatientRepository patientRepository, IMapper mapper, IProfileDataService profileDataService)
    {
        _patientRepository = patientRepository;
        _mapper = mapper;
        _profileDataService = profileDataService;
    }
    
    public async Task<IEnumerable<PatientDto>> GetAllPatientsAsync()
    {
        var response = await _patientRepository.GetAllAsync();

        var mapped = _mapper.Map<IEnumerable<PatientDto>>(response);

        var tasks = mapped.Select(async patient =>
        {
            patient.Profile = await _profileDataService.GetProfileAsync(patient.UserId);
        });

        await Task.WhenAll(tasks);
        
        return mapped;
    }

    public async Task<PatientDto?> GetPatientAsync(Guid id)
    {
        try
        {
            var response = await _patientRepository.GetByIdAsync(id);
        
            var mapped = _mapper.Map<PatientDto>(response);
            
            mapped.Profile = await _profileDataService.GetProfileAsync(mapped.UserId);

            return mapped;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error in PatientDataService.cs: {ex.Message}");
        }
        
        return null;
    }
}