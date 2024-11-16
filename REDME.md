# LINQ Extension Methods

## Dump
### :rocket: `Immediate Execution`

> External Package - `Dumpify`

- [x] `Dump`

```csharp
IEnumerable<int> collection = [1,2,3,4,5];

collection.Dump();
```

## Filtering
### :construction: `Deferred Execution`

- [x] `Where`

```csharp
IEnumerable<int> collection = [1,2,3,4,5];

collection.Where(x => x > 2).Dump();
```

- [x] `OfType`

```csharp
IEnumerable<object> collection = [1, "abc", 3, 4, 5];

IEnumerable<int> foo1 = collection.OfType<int>().Dump();
IEnumerable<string> foo2 = collection.OfType<string>().Dump();
```

## Partitioning
### :construction: `Deferred Execution`

- [x] `Skip`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5];

collection.Skip(3).Dump(); // skips first 3
```

- [x] `Take`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5];

collection.Take(3).Dump(); // takes first 3
```

- [x] `SkipLast`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5];

collection.SkipLast(3).Dump(); // skips last 3
```

- [x] `TakeLast`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5];

collection.TakeLast(3).Dump(); // takes last 3
```

- [x] `SkipWhile`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5];

collection.SkipWhile(x => x < 2).Dump(); // skips if element < 2

# For TakeWhile and SkipWhile when once the predicate returns false, then it does not run against the remaining elements inlike where clause.
# Where scans entire list
```

- [x] `TakeWhile`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5];

collection.TakeWhile(x => x < 2).Dump(); // takes if element < 2

# For TakeWhile and SkipWhile when once the predicate returns false, then it does not run against the remaining elements inlike where clause.
# Where scans entire list
```

## Projection
### :construction: `Deferred Execution`

- [x] `Select`
    - [x] With Index

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5];

collection.Select(x => x < 2).Dump();
collection.Select(x => x.ToString()).Dump();
collection.Select((val, index) => $"Index:{index} Value:{val}").Dump();
```

- [x] `SelectMany`
    - [x] `With Index`

```csharp
IEnumerable<List<int>> collection = [[1, 2, 3], [4, 5, 6]];

// collection 1 - [1, 2, 3]
// collection 1 - [4, 5, 6]
collection.SelectMany(x => x).Dump();
collection.SelectMany(x => x.Select(x => x.ToString())).Dump();
collection.SelectMany(x => x).Select(x => x.ToString()).Dump();
collection.SelectMany((collection, index) => collection.Select(ele => $"{index}, {ele}")).Dump();
```

- [x] `Cast`

```csharp
IEnumerable<object> collection = [1, 2, 3, 4, 5, 6];

collection.Cast<int>().Dump();
```

- [x] `Chunk`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

collection.Chunk(3).Dump();
collection.Chunk(3).SelectMany(x => x).Dump();
```

## Existence or Quantity Checks 
### :rocket: `Immediate Execution`

- [x] `Any`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

collection.Any(x => x > 2).Dump();  
```

- [x] `All`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

collection.All(x => x > 2).Dump();  
```

- [x] `Contains`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

collection.Contains(3).Dump();  
```

## Sequence Manipulation
### :construction: `Deferred Execution`

- [x] `Append`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

collection.Append(7).Dump();
```

- [x] `Prepend`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

collection.Prepend(0).Dump();  
```

## Aggregation Methods
### :rocket: `Immediate Execution`

- [x] `Count`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

collection.Count().Dump();
```

- [x] `TryGetNonEnumeratedCount`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

collection.TryGetNonEnumeratedCount(out var count).Dump(); 
```

- [x] `Max`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

collection.Max().Dump(); 
collection.Max(x => x * 2).Dump(); 
```

- [x] `MaxBy`

```csharp
IEnumerable<Person> collection = 
[
    new Person("John", 20), 
    new Person("Jane", 30), 
    new Person("Jack", 25)
];

collection.MaxBy(person => person.Age).Dump(); 

record Person(string Name, int Age);
```

- [x] `Min`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

collection.Min().Dump(); 
collection.Min(x => x * 2).Dump(); 
```

- [x] `MinBy`

```csharp
IEnumerable<Person> collection = 
[
    new Person("John", 20), 
    new Person("Jane", 30), 
    new Person("Jack", 25)
];

collection.MinBy(person => person.Age).Dump(); 

record Person(string Name, int Age);
```

- [x] `Sum`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

collection.Sum().Dump();

IEnumerable<object> collection = [1, 2, 3, 4, 5, 6];

collection.Sum(x => (int)x).Dump();
```

- [x] `Average`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

collection.Average().Dump();
```

- [x] `Aggregate`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

// Overload 1: creating csv
collection
    .Select(x => x.ToString())
    .Aggregate((accumulator, nextElement) => $"{accumulator}, {nextElement}")
    .Dump();

// Overload 2: adding all elements with seed 10
collection
    .Aggregate(seed:10, (accumulator, nextElement) => accumulator + nextElement)
    .Dump();

// Overload 3: adding all elements with seed 10 and then dividing by 2
collection
    .Aggregate(seed:10, (accumulator, nextElement) => accumulator + nextElement, resultSelector: x => x / 2)
    .Dump();
```

- [x] `LongCount`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

collection.LongCount().Dump();
```

## Element Operators
### :rocket: `Immediate Execution`

- [x] `First`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

// Empty Collection - throws exception
// Non Empty Collection - returns first element
collection.First().Dump();
```

- [x] `FirstOrDefault`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

// Empty Collection - returns default, 0 for int
// Non Empty Collection - returns first element
collection.FirstOrDefault().Dump();

// Empty Collection - returns specified default, -1
collection.FirstOrDefault(-1).Dump();
```

- [x] `Single`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

// Empty Collection - throws exception
// Collection having > 1 elements - throws exception
// Collection having = 1 element - returns element
collection.Single().Dump();
```

- [x] `SingleOrDefault`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

// Empty Collection - returns default, 0 for int
// Collection having > 1 elements - throws exception
// Collection having = 1 element - returns element
collection.SingleOrDefault().Dump();

// Empty Collection - returns specified default, -1
collection.SingleOrDefault(-1).Dump();
```

- [x] `Last`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

// Empty Collection - throws exception
// Non Empty Collection - returns last element
collection.Last().Dump();
```

- [x] `LastOrDefault`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

// Empty Collection - returns default, 0 for int
// Non Empty Collection - returns first element
collection.LastOrDefault().Dump();

// Empty Collection - returns specified default, -1
collection.LastOrDefault(-1).Dump();
```

- [x] `ElementAt`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

// Empty Collection - throws exception
// Non Empty Collection - returns element at specified index
collection.ElementAt(index: 0).Dump();
```

- [x] `ElementAtOrDefault`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

// Empty Collection - returns default, 0 for int
// Non Empty Collection - returns element at specified index
collection.ElementAtOrDefault(index: -1).Dump();
```

- [x] `DefaultIfEmpty` :construction: `Deferred Execution`

```csharp
IEnumerable<int> collection = [];

// Empty Collection - returns default, 0 for int
// Non Empty Collection - no action
collection.DefaultIfEmpty().Dump();
```

## Conversion Methods
### :rocket: `Immediate Execution`

- [x] `ToArray`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

collection.ToArray().Dump();
```

- [x] `ToList`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

collection.ToList().Dump();
```

- [x] `ToDictionary`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

collection
    .ToDictionary(key => key, value => value * 2)
    .Dump();
```

- [x] `ToHashSet`

```csharp
IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];

collection.ToHashSet().Dump();
```

- [x] `ToLookup`

```csharp
IEnumerable<Person> collection = 
[
    new Person("John", 20), 
    new Person("Jane", 30), 
    new Person("Jack", 30)
];

var personLookup = collection
    .ToLookup(person => person.Age)
    .Dump();

var personByAge30 = personLookup[30].Dump();

var person = personByAge30
    .FirstOrDefault()
    !.Name
    .Dump();

record Person(string Name, int Age);
```

## Generation Methods

- [x] `AsEnumerable` :construction: `Deferred Execution`

```csharp
List<Person> collection = 
[
    new Person("John", 20), 
    new Person("Jane", 30), 
    new Person("Jack", 30)
];

IEnumerable<Person> persons = collection.AsEnumerable();

record Person(string Name, int Age);
```

- [x] `AsQueryable` :construction: `Deferred Execution`

```csharp
List<Person> collection = 
[
    new Person("John", 20), 
    new Person("Jane", 30), 
    new Person("Jack", 30)
];

IQueryable<Person> persons = collection.AsQueryable();

record Person(string Name, int Age);
```

- [x] `Range` :rocket: `Immediate Execution`

```csharp
// collection of 100 numbers from 0 - 99
IEnumerable<int> collection = Enumerable.Range(start: 0, count: 100).Dump();
```

- [x] `Repeat` :rocket: `Immediate Execution`

```csharp
// collection of 10 numbers all 1
IEnumerable<int> collection = Enumerable.Repeat(element: 1, count: 10).Dump();
```

- [x] `Empty` :rocket: `Immediate Execution`

```csharp
IEnumerable<int> collection = Enumerable.Empty<int>();
```

## Set Operations
### :construction: `Deferred Execution`

- [x] `Distinct`

```csharp
IEnumerable<int> collection = [1, 2, 3, 1];

collection.Distinct().Dump();
```

- [x] `DistinctBy`

```csharp
IEnumerable<int> collection = [1, 2, 3, 1];

collection.DistinctBy(x => x > 2).Dump();

IEnumerable<Person> persons = 
[
    new Person(1, "John", 20), 
    new Person(2, "Jane", 30), 
    new Person(2, "Jane", 30), 
];

persons.DistinctBy(person => person.Id).Dump();

record Person(int Id, string Name, int Age);
```

- [x] `Union`

```csharp
IEnumerable<int> collection1 = [1, 2, 3];
IEnumerable<int> collection2 = [2, 3, 4];

collection1.Union(collection2).Dump("Union");
```

- [x] `UnionBy`

```csharp
IEnumerable<Person> collection1 = 
[
    new Person(1, "AAA", 15), 
    new Person(2, "BBB", 16), 
];

IEnumerable<Person> collection2 = 
[
    new Person(1, "AAA", 15), 
];

collection1.UnionBy(collection2, person => person.Id).Dump();

record Person(int Id, string Name, int Age);
```

- [x] `Intersect`

```csharp
IEnumerable<int> collection1 = [1, 2, 3];
IEnumerable<int> collection2 = [2, 3, 4];

collection1.Intersect(collection2).Dump("Intersect");
```

- [x] `IntersectBy`

```csharp
IEnumerable<Person> collection1 = 
[
    new Person(1, "AAA", 15), 
    new Person(2, "BBB", 16), 
];

IEnumerable<Person> collection2 = 
[
    new Person(1, "AAA", 15), 
];

collection1.IntersectBy(
    collection2.Select(x => x.Id), 
    person => person.Id).Dump();

record Person(int Id, string Name, int Age);
```

- [x] `Except`

```csharp
IEnumerable<int> collection1 = [1, 2, 3];
IEnumerable<int> collection2 = [2, 3, 4];

collection1.Except(collection2).Dump("Except");
```

- [x] `ExceptBy`

```csharp
IEnumerable<Person> collection1 = 
[
    new Person(1, "AAA", 15), 
    new Person(2, "BBB", 16), 
];

IEnumerable<Person> collection2 = 
[
    new Person(1, "AAA", 15), 
];

collection1.ExceptBy(
    collection2.Select(x => x.Id), 
    person => person.Id).Dump();

record Person(int Id, string Name, int Age);
```

- [x] `SequenceEqual`

```csharp
IEnumerable<int> collection1 = [1, 2, 3];
IEnumerable<int> collection2 = [1, 2, 3];
IEnumerable<int> collection3 = [1, 2, 3, 4];

collection1.SequenceEqual(collection2).Dump(); // true
collection1.SequenceEqual(collection3).Dump(); // false
```

## Joining & Grouping
### :construction: `Deferred Execution`

- [x] `Zip`

```csharp
IEnumerable<int> collection1 = [1, 2, 3];
IEnumerable<string> collection2 = ["a", "b", "c"];
IEnumerable<string> collection3 = ["a", "b", "c", "d"];
IEnumerable<string> collection4 = ["a", "b"];
IEnumerable<string> collection5 = ["$", "#", "&"];

// outputs - [(1, "a"), (2, "b"), (3, "c")]
collection1.Zip(collection2).Dump();

// outputs - [(1, "a"), (2, "b"), (3, "c")]
// collection3 is truncated to the length of collection1, d gets dropped
collection1.Zip(collection3).Dump();

// outputs - [(1, "a"), (2, "b")]
// collection1 is truncated to the length of collection4, 3 gets dropped
collection1.Zip(collection4).Dump();

// outputs - [(1, "a", "$"), (2, "b", "#"), (3, "c", "&")]
collection1.Zip(collection2, collection5).Dump();
```

- [x] `Join`

```csharp
IEnumerable<Person> persons = 
[
    new Person(1, "John", 20),
    new Person(2, "Jane", 30),
    new Person(3, "Doe", 40)
];

IEnumerable<Product> products = 
[
    new Product(1, "Laptop"),
    new Product(1, "Mobile"),
    new Product(2, "Tablet")
];

persons.Join(
    products,
    person => person.Id,
    product => product.PersonId,
    (person, product) => $"{person.Name} bought {product.Name}").Dump();

record Person(int Id, string Name, int Age);
record Product(int PersonId, string Name);
```

- [x] `GroupJoin`

```csharp
IEnumerable<Person> persons = 
[
    new Person(1, "John", 20),
    new Person(2, "Jane", 30),
    new Person(3, "Doe", 40)
];

IEnumerable<Product> products = 
[
    new Product(1, "Laptop"),
    new Product(1, "Mobile"),
    new Product(2, "Tablet")
];

persons.GroupJoin(
    products,
    person => person.Id,
    product => product.PersonId,
    (person, products) => $"{person.Name} bought {string.Join(',', products.Select(p => p.Name))}").Dump();

record Person(int Id, string Name, int Age);
record Product(int PersonId, string Name);
```

- [x] `Concat`

```csharp
IEnumerable<int> collection1 = [1, 2, 3];
IEnumerable<int> collection2 = [4, 5, 6];

collection1.Concat(collection2).Dump();
```

- [x] `GroupBy`

```csharp
using Dumpify;

IEnumerable<Person> persons = 
[
    new Person(1, "John", 20),
    new Person(2, "Jane", 30),
    new Person(3, "Doe", 30)
];

// grouping by age
IEnumerable<IGrouping<int, Person>> groups = persons.GroupBy(person => person.Age).Dump();

// accessing the last group
IGrouping<int, Person> lastGroup = groups.Last().Dump();

// accessing the key of the group
lastGroup.Key.Dump();

// accessing the items of the group
foreach (Person person in lastGroup)
{
    person.Dump();
}

record Person(int Id, string Name, int Age);
```

## Sorting
### :construction: `Deferred Execution`

- [x] `Order`

```csharp
IEnumerable<int> collection = [3, 5, 1, 9];

collection.Order().Dump();
```

- [x] `OrderBy`

```csharp
IEnumerable<Person> persons = 
[
    new Person(1, "John", 80),
    new Person(2, "Jane", 30),
    new Person(3, "Doe", 45)
];

persons.OrderBy(person => person.Age).Dump();

record Person(int Id, string Name, int Age);
```

- [x] `OrderByDescending`

```csharp
IEnumerable<int> collection = [3, 2, 1];

collection.OrderDescending().Dump();

IEnumerable<Person> persons = 
[
    new Person(1, "John", 80),
    new Person(2, "Jane", 30),
    new Person(3, "Doe", 45)
];

persons.OrderByDescending(person => person.Age).Dump();

record Person(int Id, string Name, int Age);
```

- [x] `ThenBy`

```csharp
IEnumerable<Person> persons = 
[
    new Person(1, "John", 80),
    new Person(2, "Jane", 30),
    new Person(3, "Doe", 45)
];

persons
    .OrderByDescending(person => person.Age)
    .ThenBy(persons => persons.Name)
    .Dump();

record Person(int Id, string Name, int Age);
```

- [x] `ThenByDescending`

```csharp
IEnumerable<Person> persons = 
[
    new Person(1, "John", 80),
    new Person(2, "Jane", 30),
    new Person(3, "Doe", 45)
];

persons
    .OrderByDescending(person => person.Age)
    .ThenByDescending(persons => persons.Name)
    .Dump();

record Person(int Id, string Name, int Age);
```

- [x] `Reverse`

```csharp
IEnumerable<int> collection = [3, 2, 1];

collection.Reverse().Dump();
```