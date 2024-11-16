# LINQ Extension Methods

## Dump
> External Package - Dumpify
- [x] Dump
```csharp
IEnumerable<int> collection = [1,2,3,4,5];

collection.Dump();
```

## Filtering

- [x] Where
```csharp
IEnumerable<int> collection = [1,2,3,4,5];

collection.Where(x => x > 2).Dump();
```

- [x] OfType
```csharp
IEnumerable<object> collection = [1, "abc", 3, 4, 5];

IEnumerable<int> foo1 = collection.OfType<int>().Dump();
IEnumerable<string> foo2 = collection.OfType<string>().Dump();
```

