using CleanArchitecture.Web.Infrastructure;
using MediatR;
using UrlShortaner.Application.UrlShortaners.Commands.CreateUrlShortaner;
using UrlShortaner.Application.UrlShortaners.Queries.GetUrlShortanerById;

namespace UrlShortaner.API.Endpoints;

public class UrlShortaners : EndpointGroupBase
{
    public override void Map(WebApplication app)
    {
        app.MapGroup(this)
            .RequireAuthorization()
            .MapGet(GetUrlShortanerById, "{id}")
            .MapPost(CreateTodoItem);
    }

    public Task<string> GetUrlShortanerById(ISender sender, string code)
    {
        return sender.Send(new GetUrlShortanerById(){ Code = code });
    }

    public Task<string> CreateTodoItem(ISender sender, CreateUrlShortaner command)
    {
        return sender.Send(command);
    }
}
