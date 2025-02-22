using FitTheraPortal.Shared.Models;

namespace FitTheraPortal.Server.Repositories;

public class PatientRepository : IPatientRepository
{
    private readonly Supabase.Client _client;

    public PatientRepository(Supabase.Client client)
    {
        _client = client;
    }

    public async Task<IEnumerable<Patient>> GetAllAsync()
    {
        var response = await _client
            .From<Patient>()
            .Get();

        return response.Models;
    }

    public async Task<Patient?> GetByIdAsync(Guid id)
    {
        var response = await _client
            .From<Patient>()
            .Where(patient => patient.Id == id)
            .Get();

        return response.Models.FirstOrDefault();
    }

    public async Task CreateAsync(Patient patient)
    {
        await _client
            .From<Patient>()
            .Insert(patient);
    }

    public async Task<Patient> UpdateAsync(Patient patient)
    {
        await patient.Update<Patient>();

        return patient;
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        await _client
            .From<Patient>()
            .Where(patient => patient.Id == id)
            .Delete();

        return true;
    }
}