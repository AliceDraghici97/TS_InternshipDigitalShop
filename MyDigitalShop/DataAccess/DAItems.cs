using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAItems
    {
     
        public DataTable GetItems()
        {
            DataTable articole = new DataTable();
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select ItemId, ItemName, ItemCode, MeasuringUnitName, ItemDescription" +
                    " from TItem";

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(articole);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return articole;
        }
        public DataTable GetItemNameById(int itemId)
        {
            DataTable articole = new DataTable();
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select ItemId, ItemName, ItemCode, MeasuringUnitName, ItemDescription" +
                    " from TItem where ItemId=@ItemId";

                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@ItemId";
                parameter.DbType = System.Data.DbType.Int32;
                parameter.Direction = System.Data.ParameterDirection.Input;
                parameter.Value = itemId;
                command.Parameters.Add(parameter);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(articole);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return articole;
        }
    }
}
