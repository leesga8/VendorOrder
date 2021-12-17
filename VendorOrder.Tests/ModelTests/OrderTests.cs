using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System;
using System.Collections.Generic;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceofOrder_Order()
    {
      Order newOrder = new Order("test", "test1", 1, "test");
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
    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "bread";
      string description = "sourdough loaf";
      int price = 5;
      string date = "1/1/2001";
      Order newOrder = new Order(title, description, price, date);

      //Act
      string updatedTitle = "potato loaf";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;

      //Assert
      Assert.AreEqual(updatedTitle, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

  }
}