using Batcheese.Models;
using Xunit;

namespace Batcheese.Tests.Models;

public class BatchesTests
{
    [Fact]
    public void Batches_WhenChangingSize_ReturnsNewBatches()
    {
        // Arrange
        var batches = new Batches<int>(2)
        {
            new(2, new[] { 1, 2 }),
            new(2, new[] { 3, 4 })
        };

        // Act
        var result = batches.ChangeSize(1);

        // Assert
        Assert.Equal(4, result.Count());
    }

    [Fact]
    public void Batches_WhenAddingBatchWithDifferentSize_ThrowsArgumentException()
    {
        // Arrange
        var batches = new Batches<int>(2);
        var batch = new Batch<int>(1);

        // Act
        void Action()
        {
            batches.Add(batch);
        }

        // Assert
        Assert.Throws<ArgumentException>(Action);
    }
}
