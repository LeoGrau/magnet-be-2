using magnetart.MagnetArt.Domain.Models;
using magnetart.Shared.Domain.Services.Communication;

namespace magnetart.MagnetArt.Domain.Services.Communication;


public class AuthorResponse: BaseResponse<Author>
{
    public AuthorResponse(Author resource) : base(resource)
    {
    }

    public AuthorResponse(string message) : base(message)
    {
    }
}