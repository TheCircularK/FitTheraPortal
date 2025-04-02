using FitTheraPortal.Client.Models;

namespace FitTheraPortal.Client.Repositories.Interfaces;

public interface IAppointmentRepository
{
    Task<IEnumerable<Appointment>> GetAllAsync();
    Task<Appointment?> GetByIdAsync(Guid id);
    Task CreateAsync(Appointment appointment);
    Task<Appointment> UpdateAsync(Appointment appointment);
    Task<bool> DeleteAsync(Guid id);
    
    Task<IEnumerable<Appointment>> GetByUserAsync(Guid userId);
    
    Task<IEnumerable<Appointment>> GetAppointmentsInRange(DateTime start, DateTime end);
}