using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceofOrder_Order()
    {
      Order newOrder = new Order();
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}