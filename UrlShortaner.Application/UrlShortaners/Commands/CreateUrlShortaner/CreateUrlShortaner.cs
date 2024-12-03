using MediatR;

namespace UrlShortaner.Application.UrlShortaners.Commands.CreateUrlShortaner;

public class CreateUrlShortaner : IRequest<string>
{
    public string Code { get; set; }
}

public class CreateUrlShortanerHandler : IRequestHandler<CreateUrlShortaner, string>
{
    public async Task<string> Handle(CreateUrlShortaner request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}