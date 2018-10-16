using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADONETExamples
{
    class Insert
    {
        static void Main(string[] args)
        {
            new Insert().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-5972U908\\MSSQLSERVER01;Initial Catalog=Student;Integrated Security=True");
                SqlCommand cm = new SqlCommand("insert into student6(id, name, email, join_date)values('102', 'Mahesh', 'mahi@example.com', '1/12/2017')", con);
                SqlCommand cm1 = new SqlCommand("insert into student6(id, name, email, join_date)values('103', 'Naresh', 'nari@example.com', '1/12/2017')", con);
                SqlCommand cm2 = new SqlCommand("insert into student6(id, name, email, join_date)values('104', 'Swathi', 'swathi@example.com', '1/12/2017')", con);
                SqlCommand cm3 = new SqlCommand("insert into student6(id, name, email, join_date)values('105', 'Govardhan', 'govar@example.com', '1/12/2017')", con);
                con.Open();
                cm1.ExecuteNonQuery();
                cm2.ExecuteNonQuery();
                cm3.ExecuteNonQuery();
                cm.ExecuteNonQuery();// by using this we can perfor insert , update , delete
              //  cm.ExecuteScalar();// it exicute only one object
              //  cm.ExecuteReader();//it return any no.of rows values
                Console.WriteLine("Record Inserted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
