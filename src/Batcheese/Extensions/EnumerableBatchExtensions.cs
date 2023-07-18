using Batcheese.Models;

namespace Batcheese.Extensions;

public static class EnumerableBatchExtensions
{
    public static Batches<T> Batch<T>(this IEnumerable<T> source, int batchSize)
    {
        var batches = new Batches<T>(batchSize);

        var batch = new Batch<T>(batchSize);

        foreach (var element in source)
        {
            batch.Add(element);

            if (batch.Count() < batchSize)
            {
                continue;
            }

            batches.Add(batch);

            batch = new Batch<T>(batchSize);
        }
        
        if (batch.Any())
        {
            batches.Add(batch);
        }

        return batches;
    }
}
