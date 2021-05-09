using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pierre.Models;
using System.Collections.Generic;
using System;

namespace Pierre.Tests
{
  [TestClass]
  public class PierreTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void PierreConstructor_CreatesInstanceOfPierre_Vendors()
    {
      Vendor newVendor = new Vendor("test vendor", "sells pies");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Vendor";
      string description = "sells pies";
      Vendor newVendor = new Vendor(name, description);
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "Test Vendor";
      string description = "sells pies";
      Vendor newVendor = new Vendor(name, description);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
        
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name1 = "Trader";
      string name2 = "Market";
      string description = "Sells pies";
      Vendor newVendor1 = new Vendor(name1, description);
      Vendor newVendor2 = new Vendor(name2, description);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name1 = "Trader";
      string name2 = "Market";
      string description = "Sells pies";
      Vendor newVendor1 = new Vendor(name1, description);
      Vendor newVendor2 = new Vendor(name2, description);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }
    
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string description = "Sells Pies";
      Order newOrder = new Order("Pies", description, 15, "01/02/2021");
      List<Order> newList = new List<Order> { newOrder };
      string name = "Trader";
      Vendor newVendor = new Vendor(name, description);
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }
  }
}