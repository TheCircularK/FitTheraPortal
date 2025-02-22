namespace FitTheraPortal.Server.Repositories;

public class AppointmentRepository
{
    public AppointmentRepository(Supabase.Client client)
    {
        _client = client;
    }

    private readonly Supabase.Client _client;
}