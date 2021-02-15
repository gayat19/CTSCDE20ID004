using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace TranportManagementBLLibrary
{
    public class EmployeeBL
    {
        SqlConnection conn=null;
        SqlCommand cmdInsert;

        public int TestCheck(int num1)
        {
            return (++num1);
        }
        public List<string> GetData()
        {
            List<string> result = new List<string>();
            result.Add("Hello");
            result.Add("Hi");
            result.Add("Welcome");
            return result;
        }

        public EmployeeBL()
        {
           //conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conTransport"].ConnectionString);
        }
        public bool CreateEmployee(Employee employee)
        {
            bool result = false;
            cmdInsert = new SqlCommand();
            cmdInsert.Connection = conn;
            cmdInsert.CommandText = "proc_InsertEmployee";
            cmdInsert.CommandType = CommandType.StoredProcedure;
            cmdInsert.Parameters.AddWithValue("@ename", employee.Name);
            cmdInsert.Parameters.AddWithValue("@eAddress", employee.Address);
            cmdInsert.Parameters.AddWithValue("@elocation", employee.Location);
            cmdInsert.Parameters.AddWithValue("@eage", employee.Age);
            cmdInsert.Parameters.AddWithValue("@ephone", employee.Phone);
            cmdInsert.Parameters.AddWithValue("@eemail", employee.Email);
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            if (cmdInsert.ExecuteNonQuery() > 0)
                result = true;
            return result;
        }
    }
}
