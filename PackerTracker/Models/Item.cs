using System.Collections.Generic;

namespace PackerTracker.Models
{
  public class Item
  {
     private static List<Item> _instances = new List<Item> {};
     public string Name { get; set; }
     public double Price { get; set; }
    // status ==yes, purchased; status ==no, not purchased.
     public string Status { get; set; }
     public double Weight { get; set; }
    // ready ==1, packed; ready ==0, unpacked.
     public int Ready { get; set; }
     public int Id{ get; }
    //  public List<Item> Items { get; set; }

    public Item(string name, double price, string status, double weight, int ready)
    {
      Name = name;
      Price = price;
      Status = status;
      Weight = weight;
      Ready = ready;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Item> GetAll()
    {
      return _instances;
    }

    public static List<Item> GetAllNotPacked()
    {
      // return list, every one with 0
      List<Item> unpackedList = new List<Item> {};
      foreach (Item item in _instances )
      {
        if (item.Ready == 0)
        {
          unpackedList.Add(item);
        }
      }
      return unpackedList;  
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Item Find(int searchId )
    {
      return _instances[searchId -1];
    }
      
  }
}