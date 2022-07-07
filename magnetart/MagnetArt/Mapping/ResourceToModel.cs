using magnetart.MagnetArt.Domain.Models;
using magnetart.MagnetArt.Domain.Services.Communication;

namespace magnetart.MagnetArt.Mapping;

public class ResourceToModel: AutoMapper.Profile
{
    public ResourceToModel()
    {
        CreateMap<Author, AuthorResponse>();
        CreateMap<Provider, ProviderResponse>();
    }
}