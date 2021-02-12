using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace TranportManagementBLLibrary
{
    public class Booking
    {
        SqlConnection conn;
        SqlCommand cmdGetBus,cmdAllocateBus;
        public Booking()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conTransport"].ConnectionString);
        }
        public List<string> GetBusForEmployee(int id)
        {
            List<string> busNumbers = new List<string>();
            DataSet dsBus = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            cmdGetBus = new SqlCommand("proc_GetBusForEmployee", conn);
            cmdGetBus.CommandType = CommandType.StoredProcedure;
            cmdGetBus.Parameters.Add("@eid",SqlDbType.Int);
            cmdGetBus.Parameters[0].Value = id;
            da.SelectCommand = cmdGetBus;
            da.Fill(dsBus, "BusNumber");
            foreach (DataRow dataRow in dsBus.Tables["BusNumber"].Rows)
            {
                busNumbers.Add(dataRow[0].ToString());
            }
            return busNumbers;
        }
        public bool AllocateBusForEmployee(int eid,string busno)
        {
           
            cmdAllocateBus = new SqlCommand("proc_allocateBusToEmployee", conn);
            cmdAllocateBus.CommandType = CommandType.StoredProcedure;
            cmdAllocateBus.Parameters.Add("@eid", SqlDbType.Int);
            cmdAllocateBus.Parameters.Add("@busno", SqlDbType.VarChar, 20);
            cmdAllocateBus.Parameters[0].Value = eid;
            cmdAllocateBus.Parameters["@busno"].Value = busno;
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Open();
                cmdAllocateBus.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
