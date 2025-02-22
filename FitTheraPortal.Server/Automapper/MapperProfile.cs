using AutoMapper;
using FitTheraPortal.Shared.Dtos;
using FitTheraPortal.Shared.Models;

namespace FitTheraPortal.Server.Automapper;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<Company, CompanyDto>();
        CreateMap<Injury, InjuryDto>()
            .ForMember(dest => dest.DateInjured, opt => opt.MapFrom(src => src.DateInjured.HasValue ? src.DateInjured : null))
            .ForMember(dest => dest.DateOk, opt => opt.MapFrom(src => src.DateOk.HasValue ? src.DateOk : null));
        CreateMap<InjuryDto, Injury>();
        CreateMap<Patient, PatientDto>();
        CreateMap<PhysicalTherapist, PhysicalTherapistDto>();
        CreateMap<Treatment, TreatmentDto>();
    }
}