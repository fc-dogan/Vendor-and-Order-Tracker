using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title {get; set;}
    public string Description {get; set;}
    public int Price {get; set;}
    public string Date {get; set;}
    public int Id {get; }
    public static int CurrentId {get; set;} = 0;

    public static List<Order> OrdersList {get; set;} = new List<Order> {};

    public Order(string title)
    {
      Title = title;
      IncrementId();
      Id = CurrentId;
      OrdersList.Add(this);
    }

    public static void IncrementId()
    {
      CurrentId ++;
    }    

    public static Order Find(int id)
    {
      for(int i = 0; i < OrdersList.Count; i++ )
      {
        if (OrdersList[i] is Order)
        {
          if(OrdersList[i].Id == id)
          {
            return OrdersList[i];
          }
        }
      }
      return null;
    }


  }
}  