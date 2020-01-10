using Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DAInvoices
    {
        public DataTable GetInvoicesById(int clientId)
        {
            DataTable facturi = new DataTable();
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select i.InvoiceId, i.InvoiceNumber, i.InvoiceDate, i.PartnerId, i.PartnerAddressId, i.UserId, i.Observations, concat(p.PartnerName, ' ' , p.PartnerSurname) as NumePartener, " +
                    " concat(padr.StreetName, ', ', padr.StreetNo, ', '," +
                    " (select CityName from TCity where CityId = padr.CityId), ', ', " +
                    " (select CountyName from TCounty where CountyId = padr.CountyId)) as AdresaClient" +
                    " from TInvoice i" +
                    " join TPartner p on p.PartnerId = i.PartnerId" +
                    " join TPartnerAddress padr on padr.PartnerAddressId = i.PartnerAddressId where p.PartnerId=@PartnerId";

                SqlParameter id = new SqlParameter();
                id.ParameterName = "@PartnerId";
                id.DbType = System.Data.DbType.Int32;
                id.Direction = System.Data.ParameterDirection.Input;
                id.Value = clientId;
                command.Parameters.Add(id);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(facturi);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return facturi;
        }
        public DataTable GetInvoices(int userId)
        {
            DataTable facturi = new DataTable();
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select i.InvoiceId, i.InvoiceNumber, i.InvoiceDate, i.PartnerId, i.PartnerAddressId, i.UserId, i.Observations, concat(p.PartnerName, ' ' , p.PartnerSurname) as NumePartener, " +
                    " concat(padr.StreetName, ', ', padr.StreetNo, ', '," +
                    " (select CityName from TCity where CityId = padr.CityId), ', ', " + 
                    " (select CountyName from TCounty where CountyId = padr.CountyId)) as AdresaClient" +
                    " from TInvoice i" +
                    " join TPartner p on p.PartnerId = i.PartnerId" +
                    " join TPartnerAddress padr on padr.PartnerAddressId = i.PartnerAddressId where UserId=@UserId";

                SqlParameter id = new SqlParameter();
                id.ParameterName = "@UserId";
                id.DbType = System.Data.DbType.Int32;
                id.Direction = System.Data.ParameterDirection.Input;
                id.Value = userId;
                command.Parameters.Add(id);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(facturi);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return facturi;
        }
        public void InsertInvoice(InvoiceModel factura)
        {
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command1 = new SqlCommand("insertInvoice", connection);
                command1.CommandType = System.Data.CommandType.StoredProcedure;
                command1.Parameters.Clear();

                SqlParameter nr = new SqlParameter();
                nr.ParameterName = "@InvoiceNumber";
                nr.DbType = System.Data.DbType.String;
                nr.Size = 256;
                nr.Direction = System.Data.ParameterDirection.Input;
                nr.Value = factura.InvoiceNumber;
                command1.Parameters.Add(nr);

                SqlParameter data = new SqlParameter();
                data.ParameterName = "@InvoiceDate";
                data.DbType = System.Data.DbType.DateTime;
                data.Direction = System.Data.ParameterDirection.Input;
                data.Value = factura.InvoiceDate;
                command1.Parameters.Add(data);

                SqlParameter idPartener = new SqlParameter();
                idPartener.ParameterName = "@PartnerId";
                idPartener.DbType = System.Data.DbType.Int32;
                idPartener.Direction = System.Data.ParameterDirection.Input;
                idPartener.Value = factura.client.ClientId;
                command1.Parameters.Add(idPartener);

                SqlParameter userId = new SqlParameter();
                userId.ParameterName = "@UserId";
                userId.DbType = System.Data.DbType.Int32;
                userId.Direction = System.Data.ParameterDirection.Input;
                userId.Value = factura.user.UserId;
                command1.Parameters.Add(userId);

                SqlParameter idAdresa = new SqlParameter();
                idAdresa.ParameterName = "@PartnerAddressId";
                idAdresa.DbType = System.Data.DbType.Int32;
                idAdresa.Direction = System.Data.ParameterDirection.Input;
                idAdresa.Value = factura.adresa.PartnerAddressId;
                command1.Parameters.Add(idAdresa);

                SqlParameter obs = new SqlParameter();
                obs.ParameterName = "@Observations";
                obs.DbType = System.Data.DbType.String;
                obs.Size = 301;
                obs.Direction = System.Data.ParameterDirection.Input;
                obs.Value = factura.Observations;
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
        public void DeleteInvoice(int invoiceId)
        {
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command1 = new SqlCommand();
                command1.Connection = connection;
                command1.CommandType = System.Data.CommandType.Text;
                command1.CommandText = "delete from TInvoice where InvoiceId=@InvoiceId";

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
        public void UpdateInvoice(InvoiceModel factura)
        {
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command1 = new SqlCommand("updateInvoice", connection);
                command1.CommandType = System.Data.CommandType.StoredProcedure;
                command1.Parameters.Clear();

                SqlParameter nr = new SqlParameter();
                nr.ParameterName = "@InvoiceNumber";
                nr.DbType = System.Data.DbType.String;
                nr.Size = 256;
                nr.Direction = System.Data.ParameterDirection.Input;
                nr.Value = factura.InvoiceNumber;
                command1.Parameters.Add(nr);

                SqlParameter data = new SqlParameter();
                data.ParameterName = "@InvoiceDate";
                data.DbType = System.Data.DbType.DateTime;
                data.Direction = System.Data.ParameterDirection.Input;
                data.Value = factura.InvoiceDate;
                command1.Parameters.Add(data);

                SqlParameter idPartener = new SqlParameter();
                idPartener.ParameterName = "@PartnerId";
                idPartener.DbType = System.Data.DbType.Int32;
                idPartener.Direction = System.Data.ParameterDirection.Input;
                idPartener.Value = factura.client.ClientId;
                command1.Parameters.Add(idPartener);

                SqlParameter invoiceId = new SqlParameter();
                invoiceId.ParameterName = "@InvoiceId";
                invoiceId.DbType = System.Data.DbType.Int32;
                invoiceId.Direction = System.Data.ParameterDirection.Input;
                invoiceId.Value = factura.InvoiceId;
                command1.Parameters.Add(invoiceId);

                SqlParameter idAdresa = new SqlParameter();
                idAdresa.ParameterName = "@PartnerAddressId";
                idAdresa.DbType = System.Data.DbType.Int32;
                idAdresa.Direction = System.Data.ParameterDirection.Input;
                idAdresa.Value = factura.adresa.PartnerAddressId;
                command1.Parameters.Add(idAdresa);

                SqlParameter obs = new SqlParameter();
                obs.ParameterName = "@Observations";
                obs.DbType = System.Data.DbType.String;
                obs.Size = 301;
                obs.Direction = System.Data.ParameterDirection.Input;
                obs.Value = factura.Observations;
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
    }
}
