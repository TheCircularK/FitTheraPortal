using System.Diagnostics;
using AutoMapper;
using FitTheraPortal.Shared.Dtos;
using FitTheraPortal.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitTheraPortal.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class PatientController : ControllerBase
{
    public PatientController(Supabase.Client client, IMapper mapper)
    {
        _client = client;
        _mapper = mapper;
    }

    private readonly Supabase.Client _client;
    private readonly IMapper _mapper;
    
    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        var response = await _client
            .From<Patient>()
            .Get();

        var mapped = _mapper.Map<List<PatientDto>>(response.Models.ToList());
        
        return Ok(mapped);
    }
}