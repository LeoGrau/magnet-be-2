using magnetart.MagnetArt.Domain.Models;
using magnetart.MagnetArt.Domain.Repositories;
using magnetart.MagnetArt.Domain.Services;
using magnetart.MagnetArt.Domain.Services.Communication;
using texlaxia_backend.Shared.Domain.Repositories;

namespace magnetart.MagnetArt.Services;

public class AuthorService:IAuthorService
{
    private readonly IAuthorRepository _authorRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AuthorService(IAuthorRepository authorRepository, IUnitOfWork unitOfWork)
    {
        _authorRepository = authorRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Author>> ListAsync()
    {
        return await _authorRepository.ListAsync();
    }

    public async Task<AuthorResponse> SaveAsync(Author author)
    {
        try
        {
            await _authorRepository.AddAsync(author);
            await _unitOfWork.CompleteAsync();

            return new AuthorResponse(author);
        }
        catch (Exception e)
        {
            return new AuthorResponse($"An error occurred while saving the author: {e.Message}");
        }
    }
}