using magnetart.MagnetArt.Domain.Models;
using magnetart.MagnetArt.Domain.Repositories;
using magnetart.MagnetArt.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace magnetart.MagnetArt.Persistence;

public class AuthorRepository:BaseRepository, IAuthorRepository
{
    public AuthorRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Author>> ListAsync()
    {
        return await _context.Authors.ToListAsync();
    }

    public async Task AddAsync(Author author)
    {
        await _context.Authors.AddAsync(author);
    }
}