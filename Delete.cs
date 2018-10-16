using System;
using System.Data.SqlClient;

namespace ADONETExamples
{
    class Delete
    {
        static void Main(string[] args)
        {
            new Delete().CreateTable();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            { 
                con = new SqlConnection("data source=LAPTOP-5972U908\\MSSQLSERVER01; database=Student; integrated security=SSPI");
                SqlCommand cm = new SqlCommand("delete from student6 where id = '101'", con);
                con.Open(); 
                cm.ExecuteNonQuery();
                Console.WriteLine("Record Deleted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
            }
            finally
            {
                con.Close();
            }
        }
    }
}