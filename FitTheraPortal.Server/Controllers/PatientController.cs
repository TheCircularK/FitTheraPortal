using FitTheraPortal.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitTheraPortal.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class PatientController : ControllerBase
{
    public PatientController(Supabase.Client client)
    {
        _client = client;
    }

    private readonly Supabase.Client _client;
    
    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        var response = await _client.From<Patient>().Get();
        
        return Ok(response.Models.ToList());
    }
}