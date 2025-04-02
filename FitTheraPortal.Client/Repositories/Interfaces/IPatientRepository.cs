using FitTheraPortal.Client.Models;

namespace FitTheraPortal.Client.Repositories.Interfaces;

public interface IPatientRepository
{
    Task<IEnumerable<Patient>> GetAllAsync();
    Task<Patient?> GetByIdAsync(Guid id);
    Task CreateAsync(Patient patient);
    Task<Patient> UpdateAsync(Patient patient);
    Task<bool> DeleteAsync(Guid id);
}