using System.Collections;

namespace Batcheese.Models;

public class Batch<T> : IEnumerable<T>
{
    private readonly IList<T> _values;

    public Batch(int size)
    {
        Size = size;
        _values = new List<T>(size);
    }
    
    public Batch(int size, IEnumerable<T> values)
    {
        Size = size;
        _values = new List<T>(values);
    }

    public int Size { get; }

    public IEnumerator<T> GetEnumerator()
    {
        return _values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public Batch<T> Add(T element)
    {
        _values.Add(element);
        return this;
    }
}
