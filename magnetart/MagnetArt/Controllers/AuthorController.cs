using AutoMapper;
using magnetart.MagnetArt.Domain.Services.Communication;

namespace magnetart.MagnetArt.Controllers;
using magnetart.MagnetArt.Domain.Models;
using magnetart.MagnetArt.Domain.Services;
using magnetart.MagnetArt.Resources;
using magnetart.Shared.Extensions;
using Microsoft.AspNetCore.Mvc;

[Route("/api/v1/[controller]")]
public class AuthorController:ControllerBase
{
    private readonly IAuthorService _authorService;
    private readonly IMapper _mapper;
    
    public AuthorController(IAuthorService authorService, IMapper mapper)
    {
        _authorService = authorService;
        _mapper = mapper;
    }
    
    [HttpGet("all")]
    public async Task<IEnumerable<AuthorResponse>> GetProviderById()
    {
        var authors= await _authorService.ListAsync();
        var resource = _mapper.Map<IEnumerable<Author>, IEnumerable<AuthorResponse>>(authors);
        return resource;
    }
    
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] AuthorResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var rAuthor = _mapper.Map<AuthorResource, Author>(resource);

        var result = await _authorService.SaveAsync(rAuthor);

        if (!result.Success)
            return BadRequest(result.Message);

        var commentResource = _mapper.Map<Author, AuthorResource>(result.Resource);

        return Ok(commentResource);
    }
}