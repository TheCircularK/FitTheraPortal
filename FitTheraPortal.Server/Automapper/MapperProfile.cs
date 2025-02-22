using AutoMapper;
using FitTheraPortal.Shared.Dtos;
using FitTheraPortal.Shared.Models;
using Profile = AutoMapper.Profile;

namespace FitTheraPortal.Server.Automapper;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<FitTheraPortal.Shared.Models.Profile, ProfileDto>();
    }
}