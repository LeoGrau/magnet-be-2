using magnetart.MagnetArt.Domain.Models;
using magnetart.MagnetArt.Domain.Services.Communication;

namespace magnetart.MagnetArt.Domain.Services;

public interface IProviderService
{
    Task<ProviderResponse> SaveAsync(Provider author);
    Task<Provider> GetByIdAsync(long id);
}