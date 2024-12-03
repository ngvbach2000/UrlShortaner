using MediatR;

namespace UrlShortaner.Application.UrlShortaners.Queries.GetUrlShortanerById;

public class GetUrlShortanerById : IRequest<string>
{
    public string Code { get; set; }
}

public class GetUrlShortanerByIdHandler : IRequestHandler<GetUrlShortanerById, string>
{
    public Task<string> Handle(GetUrlShortanerById request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}