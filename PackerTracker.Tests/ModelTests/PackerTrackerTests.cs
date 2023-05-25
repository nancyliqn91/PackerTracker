using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PackerTracker.Models;
using System;

namespace PackerTracker.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      Item.ClearAll();
    }

    // Test methods go here
    [TestMethod]
    public void ItemConstructor_CreateInstanceOfItem_Item()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      // we can also use the arrange, act, assert organization in any test. 
      //  Assert.AreEqual(ExpectedResult, CodeToTest);
      Item newItem = new Item("water", 2, "yes", 1, 1);
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void GetAll_GetAllItems_ItemList()
    {
      // arrange
      Item newItem1 = new Item("water", 2, "yes", 1, 1);
      Item newItem2 = new Item("hamburger", 10, "no", 0.5, 0); 
      List<Item> newList = new List<Item> {newItem1, newItem2};
      // act
      List<Item> result =Item.GetAll();
      // assert
      CollectionAssert.AreEqual(newList, result);  
    }

    [TestMethod]
    public void GetAll_GetAllNotPackedItems_ItemList()
    {
      // arrange
      Item newItem1 = new Item("water", 2, "yes", 1, 1);
      Item newItem2 = new Item("hamburger", 10, "no", 0.5, 0); 
      List<Item> newList = new List<Item> {newItem2};
      // act
      List<Item> result = Item.GetAllNotPacked();
      // assert
      CollectionAssert.AreEqual(newList, result);  
    }
    
  }
}

