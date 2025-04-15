using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uetwheels.models;

namespace uetwheels
{
   static class Datafile
    {
        public static List<carinfo> carlist = new List<carinfo>();
        
        static public void loadcars()
        {
            string conn = "Data Source=DESKTOP-JP10DTH;Initial Catalog=rental;Integrated Security=True;";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(("Select * from carinfo"),con);
            SqlDataReader reader= cmd.ExecuteReader();
            carlist.Clear();
            Console.WriteLine("Tihs is load cars function");
            while (reader.Read())
            {
                carinfo obj = new carinfo();
                obj.car_reg = Convert.ToInt32(reader["car_reg"]);
                obj.Brand = reader.GetString(1);
                obj.Model = reader.GetString(2);
                obj.Available = reader.GetString(3);
                obj.price = Convert.ToInt32(reader["price"]);
                Console.WriteLine("car brands"+obj.Brand);
                carlist.Add(obj);
            }
            con.Close();
        }
        

    }
}
