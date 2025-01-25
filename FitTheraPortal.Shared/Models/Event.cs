namespace FitTheraPortal.Shared.Models;

public class Event
{
    public int Id { get; set; }
    public string Type { get; set; }
    public long Duration { get; set; }
    public int MetricID { get; set; }
}