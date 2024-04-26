// ------------------------------------
// DateTimeOffsetProvider Sample
// ------------------------------------

using DateTimeOffsetProviderSample;
using NSubstitute;

namespace DateTimeOffsetProviderSampleTests;

[TestClass]
public class DateTimeOffsetProviderTests
{
    private readonly IDateTimeComparer _dateTimeComparer;
    private readonly IDateTimeOffsetProvider _dateTimeOffsetProvider;

    public DateTimeOffsetProviderTests()
    {
        _dateTimeOffsetProvider = Substitute.For<IDateTimeOffsetProvider>();

        _dateTimeComparer = new DateTimeComparer(_dateTimeOffsetProvider);

        var now = DateTimeOffset.Parse("2024-04-10");
        _dateTimeOffsetProvider.GetUtcNow().Returns(now);
    }

    [TestMethod]
    public void IsAfterNowUtc_WhenDateTimeIsAfterNow_ReturnsTrue()
    {
        // Arrange
        var dateTime = DateTimeOffset.Parse("2024-04-11");

        // Act
        var result = _dateTimeComparer.IsAfterNowUtc(dateTime);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsAfterNowUtc_WhenDateTimeIsBeforeNow_ReturnsFalse()
    {
        // Arrange
        var dateTime = DateTimeOffset.Parse("2024-04-09");

        // Act
        var result = _dateTimeComparer.IsAfterNowUtc(dateTime);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsAfterNowUtc_WhenDateTimeIsEqualToNow_ReturnsFalse()
    {
        // Arrange
        var dateTime = DateTimeOffset.Parse("2024-04-10");

        // Act
        var result = _dateTimeComparer.IsAfterNowUtc(dateTime);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsBeforeNowUtc_WhenDateTimeIsAfterNow_ReturnsFalse()
    {
        // Arrange
        var dateTime = DateTimeOffset.Parse("2024-04-11");

        // Act
        var result = _dateTimeComparer.IsBeforeNowUtc(dateTime);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsBeforeNowUtc_WhenDateTimeIsBeforeNow_ReturnsTrue()
    {
        // Arrange
        var dateTime = DateTimeOffset.Parse("2024-04-09");

        // Act
        var result = _dateTimeComparer.IsBeforeNowUtc(dateTime);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void IsBeforeNowUtc_WhenDateTimeIsEqualToNow_ReturnsFalse()
    {
        // Arrange
        var dateTime = DateTimeOffset.Parse("2024-04-10");

        // Act
        var result = _dateTimeComparer.IsBeforeNowUtc(dateTime);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsEqualToUtcNow_WhenDateTimeIsAfterNow_ReturnsFalse()
    {
        // Arrange
        var dateTime = DateTimeOffset.Parse("2024-04-11");

        // Act
        var result = _dateTimeComparer.IsEqualToUtcNow(dateTime);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsEqualToUtcNow_WhenDateTimeIsBeforeNow_ReturnsFalse()
    {
        // Arrange
        var dateTime = DateTimeOffset.Parse("2024-04-09");

        // Act
        var result = _dateTimeComparer.IsEqualToUtcNow(dateTime);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void IsEqualToUtcNow_WhenDateTimeIsEqualToNow_ReturnsTrue()
    {
        // Arrange
        var dateTime = DateTimeOffset.Parse("2024-04-10");

        // Act
        var result = _dateTimeComparer.IsEqualToUtcNow(dateTime);

        // Assert
        Assert.IsTrue(result);
    }
}