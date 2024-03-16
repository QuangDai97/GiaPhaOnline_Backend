using GiaPhaOnline.Domain.Entities;
using GiaPhaOnline.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace GiaPhaOnline.Api.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class FamilyController : ControllerBase
{
    private readonly IFamilyRepository _familyRepository;
    private readonly ILogger<FamilyController> _logger;

    public FamilyController(ILogger<FamilyController> logger, IFamilyRepository familyRepository)
    {
        _logger = logger;
        _familyRepository = familyRepository;
    }

    [HttpPost]
    public async Task<Family> AddFamily(Family family)
    {
        return await _familyRepository.AddAsync(family);
    }
}