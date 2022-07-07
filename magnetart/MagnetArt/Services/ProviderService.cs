using magnetart.MagnetArt.Domain.Models;
using magnetart.MagnetArt.Domain.Repositories;
using magnetart.MagnetArt.Domain.Services;
using magnetart.MagnetArt.Domain.Services.Communication;
using texlaxia_backend.Shared.Domain.Repositories;

namespace magnetart.MagnetArt.Services;

public class ProviderService:IProviderService
{
    private readonly IProviderRepository _providerRepository;
    private readonly IUnitOfWork _unitOfWork;

    public ProviderService(IProviderRepository providerRepository, IUnitOfWork unitOfWork)
    {
        _providerRepository = providerRepository;
        _unitOfWork = unitOfWork;
    }
    
    public async Task<ProviderResponse> SaveAsync(Provider provider)
    {
        try
        {
            await _providerRepository.AddAsync(provider);
            await _unitOfWork.CompleteAsync();

            return new ProviderResponse(provider);
        }
        catch (Exception e)
        {
            return new ProviderResponse($"An error occurred while saving the provider: {e.Message}");
        }
    }

    public async Task<Provider> GetByIdAsync(long id)
    {
        return await _providerRepository.FindByIdAsync(id);
    }
}