using ShoppingCart;

namespace ShoppingCart.Tests;

// These two tests operate on shared static state (CartDatabase).
// Neither test clears the database before or after running.
//
// Problem: whichever test runs second will see the item added by the first,
// making Count == 2 instead of the expected 1. One test always fails.
public class WithoutSetupTests
{
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
