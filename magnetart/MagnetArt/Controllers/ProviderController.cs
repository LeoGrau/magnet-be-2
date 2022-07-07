using AutoMapper;
using magnetart.MagnetArt.Domain.Models;
using magnetart.MagnetArt.Domain.Services;
using magnetart.MagnetArt.Resources;
using magnetart.Shared.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace magnetart.MagnetArt.Controllers;

[Route("/api/v1/[controller]")]
public class ProviderController:ControllerBase
{
    
    private readonly IProviderService _providerService;
    private readonly IMapper _mapper;
    
    public ProviderController(IProviderService providerService, IMapper mapper)
    {
        _providerService = providerService;
        _mapper = mapper;
    }
    
    [HttpGet("id/{id}")]
    public async Task<ProviderResource> GetProviderById(long id)
    {
        var provider= await _providerService.GetByIdAsync(id);
        var resource = _mapper.Map<Provider, ProviderResource>(provider);
        return resource;
    }
    
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] ProviderResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var rProvider = _mapper.Map<ProviderResource, Provider>(resource);

        var result = await _providerService.SaveAsync(rProvider);

        if (!result.Success)
            return BadRequest(result.Message);

        var commentResource = _mapper.Map<Provider, ProviderResource>(result.Resource);

        return Ok(commentResource);
    }
}