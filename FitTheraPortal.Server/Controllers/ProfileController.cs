using FitTheraPortal.Server.Services;
using FitTheraPortal.Shared.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FitTheraPortal.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProfileController : ControllerBase
{
    private readonly IProfileService _profileService;

    public ProfileController(IProfileService profileService)
    {
        _profileService = profileService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProfileDto>>> GetProfiles()
    {
        var profiles = await _profileService.GetAllAsync();
        return Ok(profiles);
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<ProfileDto>> GetProfileById(Guid id)
    {
        var profile = await _profileService.GetAsync(id);
        if (profile == null)
        {
            return NotFound();
        }
        return Ok(profile);
    }
}