// ------------------------------------
// DateTimeOffsetProvider Sample
// ------------------------------------

namespace DateTimeOffsetProviderSample;

public class DateTimeComparer(IDateTimeOffsetProvider dateTimeOffsetProvider) : IDateTimeComparer
{
    private readonly IDateTimeOffsetProvider _dateTimeOffsetProvider = dateTimeOffsetProvider;

    public bool IsAfterNowUtc(DateTimeOffset dateTime)
    {
        var utcNow = _dateTimeOffsetProvider.GetUtcNow();
        return dateTime > utcNow;
    }

    public bool IsBeforeNowUtc(DateTimeOffset dateTime)
    {
        var utcNow = _dateTimeOffsetProvider.GetUtcNow();
        return dateTime < utcNow;
    }

    public bool IsEqualToUtcNow(DateTimeOffset dateTime)
    {
        var utcNow = _dateTimeOffsetProvider.GetUtcNow();
        return dateTime == utcNow;
    }
}