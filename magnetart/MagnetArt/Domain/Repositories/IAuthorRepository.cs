using magnetart.MagnetArt.Domain.Models;

namespace magnetart.MagnetArt.Domain.Repositories;

public interface IAuthorRepository
{
    Task<IEnumerable<Author>> ListAsync();
    Task AddAsync(Author author);
}