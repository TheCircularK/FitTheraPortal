using AutoMapper;
using FitTheraPortal.Client.Dtos;
using FitTheraPortal.Client.Models;
using Profile = AutoMapper.Profile;

namespace FitTheraPortal.Client.Automapper;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Appointment, AppointmentDto>();
        CreateMap<Clinic, ClinicDto>();
        CreateMap<ExerciseHealthData, ExerciseHealthDataDto>();
        CreateMap<Exercise, ExerciseDto>();
        CreateMap<Injury, InjuryDto>();
        CreateMap<InjuryTreatmentPlan, InjuryTreatmentPlanDto>();
        CreateMap<Patient, PatientDto>();
        CreateMap<Models.Profile, ProfileDto>();
        CreateMap<Schedule, ScheduleDto>();
        CreateMap<SelfTreatmentExercise, SelfTreatmentExerciseDto>();
        CreateMap<SelfTreatment, SelfTreatmentDto>();
        CreateMap<Therapist, TherapistDto>();
    }
}