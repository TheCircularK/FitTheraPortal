using FitTheraPortal.Shared.Models;

namespace FitTheraPortal.Server.Repositories;

public class ScheduleRepository : IScheduleRepository
{
    private readonly Supabase.Client _client;

    public ScheduleRepository(Supabase.Client client)
    {
        _client = client;
    }

    public async Task<IEnumerable<Schedule>> GetAllAsync()
    {
        var response = await _client
            .From<Schedule>()
            .Get();

        return response.Models;
    }

    public async Task<Schedule?> GetByIdAsync(Guid id)
    {
        var response = await _client
            .From<Schedule>()
            .Where(schedule => schedule.Id == id)
            .Get();

        return response.Models.FirstOrDefault();
    }

    public async Task CreateAsync(Schedule schedule)
    {
        await _client
            .From<Schedule>()
            .Insert(schedule);
    }

    public async Task<Schedule> UpdateAsync(Schedule schedule)
    {
        await schedule.Update<Schedule>();

        return schedule;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        await _client
            .From<Schedule>()
            .Where(schedule => schedule.Id == id)
            .Delete();

        return true;
    }
}