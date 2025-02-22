using FitTheraPortal.Shared.Models;

namespace FitTheraPortal.Server.Repositories;

public class AppointmentRepository
{
    private readonly Supabase.Client _client;
    
    public AppointmentRepository(Supabase.Client client)
    {
        _client = client;
    }

    public async Task<IEnumerable<Appointment>> GetAllAsync()
    {
        var response = await _client
            .From<Appointment>()
            .Get();
        
        return response.Models;
    }

    public async Task<Appointment?> GetByIdAsync(Guid id)
    {
        var response = await _client
            .From<Appointment>()
            .Where(appointment => appointment.Id == id)
            .Get();
        
        return response.Models.FirstOrDefault();
    }

    public async Task CreateAsync(Appointment appointment)
    {
        var response = await _client
            .From<Appointment>()
            .Insert(appointment);

        return;
    }

    public async Task<Appointment> UpdateAsync(Appointment appointment)
    {
        await appointment.Update<Appointment>();
        
        return appointment;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        await _client
            .From<Appointment>()
            .Where(appointment => appointment.Id == id)
            .Delete();

        return true;
    }
}