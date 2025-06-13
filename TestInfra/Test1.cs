namespace TestInfra;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void ReturnsTrue()
    {
        Assert.AreEqual(true, true);
    }
    //
    // [TestMethod]
    // public void ReturnsFalse()
    // {
    //     Assert.AreEqual(true, false);
    // }
}