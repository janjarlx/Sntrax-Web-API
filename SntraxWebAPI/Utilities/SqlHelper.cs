using System.Data;
using System.Data.SqlClient;

namespace SntraxWebAPI.Utilities
{
    public class SqlHelper
    {

        public static DataTable GetDataTable(string connString, string procedureName, params SqlParameter[] commandParameters)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = procedureName;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    cmd.Parameters.Clear();
                    if (commandParameters != null)
                    {
                        cmd.Parameters.AddRange(commandParameters);
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {

                dt.Dispose();
            }
            return dt;
        }


        public static DataSet GetDataSet(string connString, string procedureName, params SqlParameter[] commandParameters)
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = procedureName;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandTimeout = 0;
                    cmd.Parameters.Clear();
                    if (commandParameters != null)
                    {
                        cmd.Parameters.AddRange(commandParameters);
                    }
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dataSet);
                    }
                }
            }
            catch (Exception ex)
            {
                dataSet = null;
                throw new Exception(ex.ToString());
            }
            finally
            {
                if (dataSet != null)
                    dataSet.Dispose();
            }
            return dataSet;
        }
    }
}
