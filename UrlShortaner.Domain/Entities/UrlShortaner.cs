using UrlShortaner.Domain.Common;

namespace UrlShortaner.Domain.Entities;

public class UrlShortaner : BaseAuditableEntity
{
    public string Url { get; set; }
    public string Code { get; set; }
}
