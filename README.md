# .NET Batcheese

A lightweight, simple to use extension for dealing with large collections in .NET. 

Batcheese allows you to take a large `IEnumerable<T>` and divide it into smaller manageable `Batch<T>` objects with a maximum defined size. This is particularly useful when you need to process large amounts of data in chunks.

## Installation
To include this functionality in your project, simply add a reference to the `Batcheese` project.

## Usage
The Batch functionality is added as an extension method for any IEnumerable<T> collection.

``` c#
IEnumerable<int> values = Enumerable.Range(1, 100);
Batches<int> batches = values.Batch(10);
```
## Features
- Extension method syntax for chaining and easy use.
- Provides a 'Batches' class that contains 'Batch' objects.
- Each 'Batch' is an enumerable containing your items.
- Ability to modify batch size and reallocate the items.

## Contribution
Got an idea to make this even more awesome or found a bug? Contributions are welcome!

## License
This project is licensed under the [MIT License](LICENSE).

# Feedback
I hope you find the `Batcheese` framework useful. Please feel free to leave any comments, requests, or suggestions.

Happy coding!
