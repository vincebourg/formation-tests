using ShoppingCart;

namespace ShoppingCart.Tests;

// xUnit creates a new instance of this class before every [Fact].
// The constructor is the setup  — runs before each test.
// Dispose()       is the teardown — runs after  each test.
//
// Both calls to Clear() are intentional:
//   - constructor: guards against leftover state from a previous test class
//   - Dispose:     leaves the database clean for whatever runs next
public class WithSetupTests : IDisposable
{
    public WithSetupTests()
    {
        CartDatabase.Clear();
    }

    public void Dispose()
    {
        CartDatabase.Clear();
    }

    [Fact]
    public void AddApple_CountShouldBeOne()
    {
        CartDatabase.Add("Apple");

        Assert.Equal(1, CartDatabase.Count);
    }

    [Fact]
    public void AddBanana_CountShouldBeOne()
    {
        CartDatabase.Add("Banana");

        Assert.Equal(1, CartDatabase.Count);
    }
}
