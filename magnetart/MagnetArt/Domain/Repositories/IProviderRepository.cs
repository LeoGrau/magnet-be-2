using magnetart.MagnetArt.Domain.Models;
using magnetart.MagnetArt.Domain.Services.Communication;

namespace magnetart.MagnetArt.Domain.Repositories;

public interface IProviderRepository
{
    Task AddAsync(Provider provider);
    Task<Provider> FindByIdAsync(long id);
}