using magnetart.MagnetArt.Domain.Models;
using magnetart.MagnetArt.Domain.Repositories;
using magnetart.MagnetArt.Domain.Services.Communication;
using magnetart.MagnetArt.Persistence.Context;

namespace magnetart.MagnetArt.Persistence;

public class ProviderRepository:BaseRepository,IProviderRepository
{
    public ProviderRepository(AppDbContext context) : base(context)
    {
    }

    public async Task AddAsync(Provider provider)
    {
        await _context.Providers.AddAsync(provider);
    }

    public async Task<Provider> FindByIdAsync(long id)
    {
        return await _context.Providers.FindAsync(id);
    }
}