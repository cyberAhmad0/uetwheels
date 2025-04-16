using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uetwheels.models
{
    public class carinfo
    {
       public  int car_reg { get; set; }
       public string Brand { get; set; }
       public string Model { get; set; }
       public string Available {  get; set; }
       public int price {  get; set; }

        //public carinfo(int id,string name,string model,string available,string price)
        //{ 
        //    this.car_reg = id;
        //    this.Brand = name;
        //    this.Model = model;
        //    this.Available = available;
        //    this.price = int.Parse(price);
        //}
    }
}
