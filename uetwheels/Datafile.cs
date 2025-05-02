using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uetwheels.models;


namespace uetwheels
{
    static class Datafile
    {
        public static List<carinfo> carlist = new List<carinfo>();
        public static List<customerinfo> customerlist = new List<customerinfo>();
        public static void loadcars()
        {
            string conn = "Data Source=DESKTOP-3BTGOGP\\SQLEXPRESS;Initial Catalog=rental;Integrated Security=True;"
;
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(("Select * from carinfo"), con);
            SqlDataReader reader = cmd.ExecuteReader();
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
                Console.WriteLine("car brands" + obj.Brand);
                carlist.Add(obj);
            }
            con.Close();
        }

        public static void addcustomer()
        {
            string conn = "Data Source=DESKTOP-3BTGOGP\\SQLEXPRESS;Initial Catalog=rental;Integrated Security=True;";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(("Select * from customer"), con);
            SqlDataReader reader = cmd.ExecuteReader();
            customerlist.Clear();
            Console.WriteLine("Tihs is load cars function");
            while (reader.Read())
            {
                customerinfo obj = new customerinfo();
                obj.cust_id = Convert.ToInt32(reader["cust_id"]);
                obj.Name = reader.GetString(1);
                obj.Address = reader.GetString(2);
                obj.Phone = reader.GetString(3);
                customerlist.Add(obj);
            }
        }
       
    }
}
