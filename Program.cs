using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDB
{
     class Program
    {
        static string connectionstring = "Data Source=DESKTOP-U13J222\\SQLEXPRESS;Initial Catalog=SampleDB;Integrated Security=True";
        static SqlConnection conn = new SqlConnection(connectionstring);


        static void Main(string[] args)
        {

            string query = "Select * from studd";
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                conn.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                  
                    while (reader.Read())
                    {
                        // Access the data by column index or column name
                        int Id = reader.GetInt32(0); // Assuming the first column is of type INT
                        string fName = reader.GetString(1);
                        string lName = reader.GetString(2);
                        int Age = reader.GetInt32(3);
                        string Password = reader.GetString(4);

                        // Do something with the data
                        Console.WriteLine($"ID: {Id}, lName: {lName}, Age: {Age}, Password :{Password}");
                    }
                }
            }





        }
    }
}




