// ------------------------------------
// DateTimeOffsetProvider Sample
// ------------------------------------

namespace DateTimeOffsetProviderSample;

public interface IDateTimeOffsetProvider
{
    DateTimeOffset GetUtcNow();
}