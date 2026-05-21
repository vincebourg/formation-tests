using Xunit;

// Disable parallel execution across test collections so tests run sequentially.
// This makes the state-pollution demo deterministic: WithoutSetupTests always
// leaves items in CartDatabase, which WithSetupTests sees and must clean up.
[assembly: CollectionBehavior(DisableTestParallelization = true)]
