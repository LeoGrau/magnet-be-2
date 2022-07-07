using magnetart.MagnetArt.Domain.Models;
using magnetart.MagnetArt.Domain.Services.Communication;

namespace magnetart.MagnetArt.Domain.Services;

public interface IAuthorService
{
    Task<IEnumerable<Author>> ListAsync();
    Task<AuthorResponse> SaveAsync(Author author);
}