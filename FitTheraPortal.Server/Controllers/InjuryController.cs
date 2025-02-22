using AutoMapper;
using FitTheraPortal.Shared.Dtos;
using FitTheraPortal.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Supabase.Postgrest;

namespace FitTheraPortal.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class InjuryController : ControllerBase
{
    public InjuryController(Supabase.Client client, IMapper mapper)
    {
        _client = client;
        _mapper = mapper;
    }

    private readonly Supabase.Client _client;
    private readonly IMapper _mapper;

    [HttpGet("{Id}")]
    public async Task<IActionResult> Get([FromRoute] int Id)
    {
        var response = await _client
            .From<Injury>()
            .Where(injury => injury.Id == Id)
            .Single();
        
        var mapped = _mapper.Map<InjuryDto>(response);
        
        return Ok(mapped);
    }

    [HttpGet("{patientId}/injuries/current")]
    public async Task<IActionResult> GetCurrentInjuries([FromRoute] int patientId)
    {
        try
        {
            var response = await _client
                .From<Injury>()
                .Where(injury => injury.PatientId == patientId)
                .Get();
            
            var mapped = _mapper.Map<List<InjuryDto>>(response.Models.ToList());
        
            return Ok(mapped);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpGet("{patientId}/injuries/past")]
    public async Task<IActionResult> GetPastInjuries([FromRoute] int patientId)
    {
        try
        {
            var query = _client
                .From<Injury>()
                .Where(injury => injury.PatientId == patientId && injury.DateOk.HasValue);

            var rows = await query.Get();

            var mapped = _mapper.Map<List<InjuryDto>>(rows.Models.ToList());

            return Ok(mapped);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}