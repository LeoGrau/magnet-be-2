using magnetart.MagnetArt.Domain.Models;
using magnetart.MagnetArt.Domain.Services.Communication;

namespace magnetart.MagnetArt.Mapping;

public class ModelToResource: AutoMapper.Profile
{
    public ModelToResource()
    {
        CreateMap<AuthorResponse, Author>();
        CreateMap<ProviderResponse, Provider>();
    }
}