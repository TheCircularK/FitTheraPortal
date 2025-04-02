using AutoMapper;
using BlazorCalendar.Models;
using FitTheraPortal.Client.DataServices.Interfaces;
using FitTheraPortal.Client.Dtos;
using FitTheraPortal.Client.Enums;
using FitTheraPortal.Client.Models;
using FitTheraPortal.Client.Repositories.Interfaces;

namespace FitTheraPortal.Client.DataServices.Implementations;

public class AppointmentDataService : IAppointmentDataService
{
    private readonly IAppointmentRepository _repository;
    private readonly IPatientDataService _patientDataService;
    private readonly IMapper _mapper;

    public AppointmentDataService(IAppointmentRepository repository, IPatientDataService patientDataService, IMapper mapper)
    {
        _repository = repository;
        _patientDataService = patientDataService;
        _mapper = mapper;
    }
    
    public async Task<IEnumerable<Tasks>> GetEventsByMonthAsync(DateTime date)
    {
        return await GetAppointmentsInRange(DateRange.Monthly);
    }

    public async Task<IEnumerable<Tasks>> GetEventsByWeekAsync(DateTime date)
    {
        return await GetAppointmentsInRange(DateRange.Weekly);
    }

    public async Task<IEnumerable<Tasks>> GetEventsByDayAsync(DateTime date)
    {
        return await GetAppointmentsInRange(DateRange.Daily);
    }
    
    private async Task<IEnumerable<Tasks>> GetAppointmentsInRange(DateRange range)
    {
        DateTime beginning;
        DateTime end;
        
        var dates = GetStartAndEndDates(range);
        
        beginning = dates.Item1;
        end = dates.Item2;

        var appointments = await _repository.GetAppointmentsInRange(beginning, end);
    
        var tasks = await ConvertAppointments(appointments);
        
        return tasks;
    }

    private (DateTime, DateTime) GetStartAndEndDates(DateRange range)
    {
        var today = DateTime.Today;
        DateTime beginning;
        DateTime end;

        switch (range)
        {
            case DateRange.Yearly:
                beginning = new DateTime(today.Year, 1, 1);
                end = new DateTime(today.Year, 12, 31);
                break;

            case DateRange.Monthly:
                beginning = new DateTime(today.Year, today.Month, 1);
                end = beginning.AddMonths(1).AddDays(-1);
                break;

            case DateRange.Weekly:
                var diff = today.DayOfWeek - DayOfWeek.Sunday;
                beginning = today.AddDays(-diff);
                end = beginning.AddDays(6);
                break;

            case DateRange.Daily:
                beginning = today;
                end = today.AddDays(1).AddSeconds(-1);
                break;

            default:
                throw new ArgumentOutOfRangeException(nameof(range), range, "Unknown DateRange value.");
        }

        return (beginning, end);
    }

    private async Task<IEnumerable<Tasks>> ConvertAppointments(IEnumerable<Appointment> appointments)
    {
        List<Tasks> taskList = new List<Tasks>(appointments.Count());

        var appointmentList = appointments.ToList();
        
        for (int i = 0; i < appointmentList.Count(); i++)
        {
            var appointment = appointmentList[i];
            
            var patient = await _patientDataService.GetPatientAsync(appointment.PatientId);
            
            string code = string.Empty;
            string color = string.Empty;

            if (appointment.Canceled)
            {
                code = "CANCELED";
                color = "#FF4C4C";
            }
            else if (appointment.Accepted)
            {
                code = "ACCEPTED";
                color = "#2980B9";
            }
            else if (appointment.Confirmed)
            {
                code = "CONFIRMED";
                color = "#27AE60";
            }
            else
            {
                code = "PENDING";
                color = "gray";
            }
            
            var task = new Tasks()
            {
                ID = i,
                DateStart = appointment.Start,
                DateEnd = appointment.End,
                Code = code,
                Caption = patient.Profile.FirstName + " " + patient.Profile.LastName,
                Color = color,
            };
            
            taskList.Add(task);
        }
        
        return taskList;
    }
}