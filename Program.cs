using Dumpify;

IEnumerable<object> collection = [1, "abc", 3, 4, 5];

IEnumerable<int> foo1 = collection.OfType<int>().Dump();
IEnumerable<string> foo2 = collection.OfType<string>().Dump();







