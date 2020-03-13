
using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    public string Name {get; set;}
    public string Description {get; set;}
    public List<Order> OrdersList {get; set;} 
    public int Id {get; set;}
    public static int CurrentId {get; set;} = 0;

    public static List<Vendor> VendorsList {get; set;} = new List<Vendor> {};

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      OrdersList = new List <Order>{};
      IncrementId();
      Id = CurrentId;
      VendorsList.Add(this);
    }

    public static void IncrementId()
    {
      CurrentId ++;
    }    

    public void AddOrder(Order order)
    {
      OrdersList.Add(order);
    }

    public static Vendor Find(int id)
    {
      for(int i = 0; i < VendorsList.Count; i++ )
      {
        if (VendorsList[i] is Vendor)
        {
          if(VendorsList[i].Id == id)
          {
            return Vendors[i];
          }
        }
      }
      return null;
    }    

  }
}  