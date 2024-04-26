// ------------------------------------
// DateTimeOffsetProvider Sample
// ------------------------------------

namespace DateTimeOffsetProviderSample;

public class DateTimeOffsetProvider : IDateTimeOffsetProvider
{
    public DateTimeOffset GetUtcNow() => DateTimeOffset.UtcNow;
}