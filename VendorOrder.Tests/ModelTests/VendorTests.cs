using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test", "Vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }  [TestMethod]
  public void GetName_ReturnsName_String()
  {
    //Arrange
    string name = "Test";
    string description = "Vendor";
    Vendor newVendor = new Vendor(name, description);

    //Act
    string result = newVendor.Name;

    //Assert
    Assert.AreEqual(name, result);
  }

  [TestMethod]
  public void GetId_ReturnsVendorId_Int()
  {
    //Arrange
    string name = "Test";
    string description = "Vendor";
    Vendor newVendor = new Vendor(name, description);

    //Act
    int result = newVendor.Id;

    //Assert
    Assert.AreEqual(1, result);
  }

  [TestMethod]
  public void GetAll_ReturnsAllVendorObjects_VendorList()
  {
    //Arrange
    string name = "Test";
    string description = "Best";
    
    string name2 = "Mest";
    string description2 = "Gest";

    Vendor newVendor = new Vendor(name, description);
    Vendor newVendor2 = new Vendor(name2, description2);

    List<Vendor> newList = new List<Vendor> { newVendor, newVendor2 };

    //Act
    List<Vendor> result = Vendor.GetAll();

    //Assert
    CollectionAssert.AreEqual(newList, result);
  }
  }
}