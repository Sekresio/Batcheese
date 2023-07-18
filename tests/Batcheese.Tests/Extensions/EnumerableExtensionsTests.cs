using Batcheese.Extensions;
using FluentAssertions;
using Xunit;

namespace Batcheese.Tests.Extensions;

public class EnumerableExtensionsTests
{
    [Fact]
    public void Batch_WhenCalledWithEmptyEnumerable_ReturnsEmptyEnumerable()
    {
        // Arrange
        var source = Enumerable.Empty<int>();
        const int batchSize = 1;

        // Act
        var result = source.Batch(batchSize);

        // Assert
        Assert.Empty(result);
    }
    
    [Fact]
    public void Batch_WhenCalledWithBatchSizeOfOne_ReturnsSingleBatch()
    {
        // Arrange
        var source = new[] { 1, 2, 3 };
        const int batchSize = 1;

        // Act
        var result = source.Batch(batchSize).ToArray();

        // Assert
        result.Should().HaveCount(3);
    }

    [Fact]
    public void Batch_WhenCalledWithBatchSizeOfTwo_ReturnsTwoBatches()
    {
        // Arrange
        var source = new[] { 1, 2, 3 };
        const int batchSize = 2;

        // Act
        var result = source.Batch(batchSize).ToArray();

        // Assert
        result.Should().HaveCount(2);
    }
}
