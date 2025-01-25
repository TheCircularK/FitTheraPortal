using FitTheraPortal.Shared.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace FitTheraPortal.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TreatmentController : ControllerBase
{
    public TreatmentController(Supabase.Client client)
    {
        _client = client;
    }

    private readonly Supabase.Client _client;
    
    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        var response = await _client.From<Treatment>().Get();
        
        return Ok(response.Models);
    }
}