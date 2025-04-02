using FitTheraPortal.Client.Models;

namespace FitTheraPortal.Client.Repositories.Interfaces;

public interface ITherapistRepository
{
    Task<IEnumerable<Therapist>> GetAllAsync();
    Task<Therapist?> GetByIdAsync(Guid id);
    Task CreateAsync(Therapist therapist);
    Task<Therapist> UpdateAsync(Therapist therapist);
    Task<bool> DeleteAsync(Guid id);
}