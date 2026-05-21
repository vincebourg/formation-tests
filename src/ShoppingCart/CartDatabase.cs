namespace ShoppingCart;

// Simulates shared external state: a database, a file, a singleton service, etc.
// The static list is process-wide — every test that touches it sees the same data.
public static class CartDatabase
{
    private static readonly List<string> _items = new();

    public static void Add(string item) => _items.Add(item);
    public static int Count => _items.Count;
    public static void Clear() => _items.Clear();
}
