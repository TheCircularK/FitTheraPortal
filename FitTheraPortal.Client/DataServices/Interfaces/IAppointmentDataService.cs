using BlazorCalendar.Models;
using FitTheraPortal.Client.Dtos;
using FitTheraPortal.Client.Enums;

namespace FitTheraPortal.Client.DataServices.Interfaces;

public interface IAppointmentDataService
{
    Task<IEnumerable<Tasks>> GetEventsByMonthAsync(DateTime date);
    Task<IEnumerable<Tasks>> GetEventsByWeekAsync(DateTime date);
    Task<IEnumerable<Tasks>> GetEventsByDayAsync(DateTime date);
}