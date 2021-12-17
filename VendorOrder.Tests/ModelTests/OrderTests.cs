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
      Order newOrder = new Order("test","test1",1,"test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    } 
    
    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "bread";
      string description = "sourdough loaf";
      int price = 5;
      string date = "1/1/2001";
      Order newOrder = new Order(title, description, price, date);
      //Act
      string result = newOrder.Title;
      //Assert
      Assert.AreEqual(title, result);
    }
  }
}