using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAInvoiceDetails
    {
        public DataTable GetDetails(int id)
        {
            DataTable detalii = new DataTable();
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select id.InvoiceDetailId, id.InvoiceId, id.ItemId, id.Qtty," +
                    " id.Price, id.Amount, id.Observations, i.ItemName" +
                    " from TInvoiceDetail id" +
                    " join TItem i on i.ItemId = id.ItemId" +
                    " where id.InvoiceId=@InvoiceId";

                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@InvoiceId";
                pId.DbType = System.Data.DbType.Int32;
                pId.Direction = System.Data.ParameterDirection.Input;
                pId.Value = id;
                command.Parameters.Add(pId);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(detalii);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return detalii;
        }
        public DataTable GetItemsByInvoiceId(int id)
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
                    " from TItem where ";

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
        public void InsertInvoiceDetail(InvoiceDetailModel detaliu)
        {
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command1 = new SqlCommand("insertInvoiceDetail", connection);
                command1.CommandType = System.Data.CommandType.StoredProcedure;
                command1.Parameters.Clear();

                SqlParameter invoiceId = new SqlParameter();
                invoiceId.ParameterName = "@InvoiceId";
                invoiceId.DbType = System.Data.DbType.Int32;
                invoiceId.Direction = System.Data.ParameterDirection.Input;
                invoiceId.Value = detaliu.Factura.InvoiceId;
                command1.Parameters.Add(invoiceId);

                SqlParameter itemId = new SqlParameter();
                itemId.ParameterName = "@ItemId";
                itemId.DbType = System.Data.DbType.Int32;
                itemId.Direction = System.Data.ParameterDirection.Input;
                itemId.Value = detaliu.Articol.ItemId;
                command1.Parameters.Add(itemId);

                SqlParameter qtty = new SqlParameter();
                qtty.ParameterName = "@Qtty";
                qtty.DbType = System.Data.DbType.Decimal;
                qtty.Direction = System.Data.ParameterDirection.Input;
                qtty.Value = detaliu.Qtty;
                command1.Parameters.Add(qtty);

                SqlParameter price = new SqlParameter();
                price.ParameterName = "@Price";
                price.DbType = System.Data.DbType.Decimal;
                price.Direction = System.Data.ParameterDirection.Input;
                price.Value = detaliu.Price;
                command1.Parameters.Add(price);

                SqlParameter amount = new SqlParameter();
                amount.ParameterName = "@Amount";
                amount.DbType = System.Data.DbType.Decimal;
                amount.Direction = System.Data.ParameterDirection.Input;
                amount.Value = detaliu.Amount;
                command1.Parameters.Add(amount);

                SqlParameter obs = new SqlParameter();
                obs.ParameterName = "@Observations";
                obs.DbType = System.Data.DbType.String;
                obs.Size = 301;
                obs.Direction = System.Data.ParameterDirection.Input;
                obs.Value = detaliu.Observations;
                command1.Parameters.Add(obs);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = command1;
                adapter.InsertCommand.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void UpdateInvoiceDetail(InvoiceDetailModel detaliu)
        {
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command1 = new SqlCommand("updateInvoiceDetail", connection);
                command1.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter invoiceDetId = new SqlParameter();
                invoiceDetId.ParameterName = "@InvoiceDetailId";
                invoiceDetId.DbType = System.Data.DbType.Int32;
                invoiceDetId.Direction = System.Data.ParameterDirection.Input;
                invoiceDetId.Value = detaliu.InvoiceDetailId;
                command1.Parameters.Add(invoiceDetId);

                SqlParameter invoiceId = new SqlParameter();
                invoiceId.ParameterName = "@InvoiceId";
                invoiceId.DbType = System.Data.DbType.Int32;
                invoiceId.Direction = System.Data.ParameterDirection.Input;
                invoiceId.Value = detaliu.Factura.InvoiceId;
                command1.Parameters.Add(invoiceId);

                SqlParameter itemId = new SqlParameter();
                itemId.ParameterName = "@ItemId";
                itemId.DbType = System.Data.DbType.Int32;
                itemId.Direction = System.Data.ParameterDirection.Input;
                itemId.Value = detaliu.Articol.ItemId;
                command1.Parameters.Add(itemId);

                SqlParameter price = new SqlParameter();
                price.ParameterName = "@Price";
                price.DbType = System.Data.DbType.Decimal;
                price.Direction = System.Data.ParameterDirection.Input;
                price.Value = detaliu.Price;
                command1.Parameters.Add(price);

                SqlParameter qtty = new SqlParameter();
                qtty.ParameterName = "@Qtty";
                qtty.DbType = System.Data.DbType.Decimal;
                qtty.Direction = System.Data.ParameterDirection.Input;
                qtty.Value = detaliu.Qtty;
                command1.Parameters.Add(qtty);

                SqlParameter amount = new SqlParameter();
                amount.ParameterName = "@Amount";
                amount.DbType = System.Data.DbType.Decimal;
                amount.Direction = System.Data.ParameterDirection.Input;
                amount.Value = detaliu.Amount;
                command1.Parameters.Add(amount);

                SqlParameter obs = new SqlParameter();
                obs.ParameterName = "@Observations";
                obs.DbType = System.Data.DbType.String;
                obs.Size = 301;
                obs.Direction = System.Data.ParameterDirection.Input;
                obs.Value = detaliu.Observations;
                command1.Parameters.Add(obs);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.UpdateCommand = command1;
                adapter.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void DeleteAllDetails(int invoiceId)
        {
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command1 = new SqlCommand();
                command1.Connection = connection;
                command1.CommandType = System.Data.CommandType.Text;
                command1.CommandText = "delete from TInvoiceDetail where InvoiceId=@InvoiceId";

                SqlParameter id = new SqlParameter();
                id.ParameterName = "@InvoiceId";
                id.DbType = System.Data.DbType.Int32;
                id.Direction = System.Data.ParameterDirection.Input;
                id.Value = invoiceId;
                command1.Parameters.Add(id);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.DeleteCommand = command1;
                adapter.DeleteCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void DeleteSelectedDetail(int invoiceDetId)
        {
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command1 = new SqlCommand();
                command1.Connection = connection;
                command1.CommandType = System.Data.CommandType.Text;
                command1.CommandText = "delete from TInvoiceDetail where InvoiceDetailId=@InvoiceDetailId";

                SqlParameter id = new SqlParameter();
                id.ParameterName = "@InvoiceDetailId";
                id.DbType = System.Data.DbType.Int32;
                id.Direction = System.Data.ParameterDirection.Input;
                id.Value = invoiceDetId;
                command1.Parameters.Add(id);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.DeleteCommand = command1;
                adapter.DeleteCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
