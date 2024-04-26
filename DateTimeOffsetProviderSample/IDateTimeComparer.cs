// ------------------------------------
// DateTimeOffsetProvider Sample
// ------------------------------------

namespace DateTimeOffsetProviderSample;

public interface IDateTimeComparer
{
    bool IsAfterNowUtc(DateTimeOffset dateTime);

    bool IsBeforeNowUtc(DateTimeOffset dateTime);

    bool IsEqualToUtcNow(DateTimeOffset dateTime);
}