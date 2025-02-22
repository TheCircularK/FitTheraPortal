using FitTheraPortal.Shared.Models;

namespace FitTheraPortal.Server.Repositories;

public interface IScheduleRepository
{
    Task<IEnumerable<Schedule>> GetAllAsync();
    Task<Schedule?> GetByIdAsync(Guid id);
    Task CreateAsync(Schedule schedule);
    Task<Schedule> UpdateAsync(Schedule schedule);
    Task<bool> DeleteAsync(Guid id);
}