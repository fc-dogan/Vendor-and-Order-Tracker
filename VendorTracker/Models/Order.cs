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

    public Order(string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
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

    public void AddOrder(Order order)
    {
      OrdersList.Add(order);
    }

    public static void ClearAll()
    {
      OrdersList.Clear();
    }

    // public static void Delete(int id)
    // {
    //   for (int i = 0; i < OrderList.Count; i++)
    //   {
    //     if (OrderList[i] is Order)
    //     {
    //       if(OrderList[i].Id == id)
    //       {
    //         OrderList.RemoveAt(i);
    //       }
    //     }        
    //   }
    // }


  }
}  