using System.Collections.Generic;

namespace Pierre.Models
{
  public class Order
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public string Date { get; set; }
    public int Id { get; }
    private static List<Order> _orders = new List<Order> { };

    public Order(string name, string description, int price, string date)
    {
      Name = name;
      Description = description;
      Price = price;
      Date = date;
      _orders.Add(this);
      Id = _orders.Count;
    }

    public static List<Order> GetAll()
    {
      return _orders;
    }

    public static void ClearAll()
    {
      _orders.Clear();
    }

    public static Order Find(int searchId)
    {
      return _orders[searchId-1];
    }
  }
}

