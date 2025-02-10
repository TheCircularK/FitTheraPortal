using AutoMapper;
using FitTheraPortal.Shared.Dtos;
using FitTheraPortal.Shared.Models;

namespace FitTheraPortal.Server.Automapper;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Patient, PatientDto>();
        CreateMap<PatientDto, Patient>();
    }
}