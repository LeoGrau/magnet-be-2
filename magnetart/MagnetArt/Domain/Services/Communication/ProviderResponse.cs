using magnetart.MagnetArt.Domain.Models;
using magnetart.Shared.Domain.Services.Communication;

namespace magnetart.MagnetArt.Domain.Services.Communication;


public class ProviderResponse: BaseResponse<Provider>
{
    public ProviderResponse(Provider resource) : base(resource)
    {
    }

    public ProviderResponse(string message) : base(message)
    {
    }
}