
using UrlShortaner.Domain.Common;

namespace UrlShortaner.Domain.Events;

public class UrlShoertanerCreatedEvent : BaseEvent
{
    public UrlShoertanerCreatedEvent(Entities.UrlShortaner item)
    {
        Item = item;
    }

    public Entities.UrlShortaner Item { get; }
}
