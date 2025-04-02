using FitTheraPortal.Client.Dtos;

namespace FitTheraPortal.Client.DataServices.Interfaces;

public interface IPatientDataService
{
    Task<IEnumerable<PatientDto?>> GetAllPatientsAsync();
    Task<PatientDto?> GetPatientAsync(Guid id);
}