using System.Collections;
using Batcheese.Extensions;

namespace Batcheese.Models;

public class Batches<T> : IEnumerable<Batch<T>>
{
    private readonly IList<Batch<T>> _batches = new List<Batch<T>>();

    public Batches(int batchSize)
    {
        BatchSize = batchSize;
    }

    public int BatchSize { get; }

    public IEnumerator<Batch<T>> GetEnumerator()
    {
        return _batches.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(Batch<T> batch)
    {
        if (batch.Size != BatchSize)
        {
            throw new ArgumentException($"Batch size must be {BatchSize}.", nameof(batch));
        }
        
        _batches.Add(batch);
    }

    public Batches<T> ChangeSize(int newSize)
    {
        var values = new List<T>();

        foreach (var batch in _batches)
        {
            values.AddRange(batch);
        }

        return values.Batch(newSize);
    }
    
    public IEnumerable<T> Flatten()
    {
        return _batches.SelectMany(batch => batch);
    }
}
