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
    public class DAAddress
    {
        public DataTable GetAddresses(int id)
        {
            DataTable adrese = new DataTable();
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select tp.PartnerId, tp.PartnerAddressId, tp.CityId, tp.CountyId, " +
                    "tp.StreetName, tp.StreetNo, co.CountyName, c.CityName from TPartnerAddress tp " +
                    "join TCity c on c.CityId = tp.CityId join TCounty co on co.CountyId = tp.CountyId " +
                    "where PartnerId=@PartnerId";

                SqlParameter pId = new SqlParameter();
                pId.ParameterName = "@PartnerId";
                pId.DbType = System.Data.DbType.Int32;
                pId.Direction = System.Data.ParameterDirection.Input;
                pId.Value = id;
                command.Parameters.Add(pId);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(adrese);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return adrese;
        }
        public DataTable GetCities()
        {
            DataTable adrese = new DataTable();
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select c.CityId, c.CityName from TCity c ";

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(adrese);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return adrese;
        }
        public DataTable GetCounties()
        {
            DataTable adrese = new DataTable();
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select c.CountyId, c.CountyName from TCounty c ";

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(adrese);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return adrese;
        }
        public void InsertAddress(AddressModel adresa)
        {
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command1 = new SqlCommand("insertAddress", connection);
                command1.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter idPartner = new SqlParameter();
                idPartner.ParameterName = "@PartnerId";
                idPartner.DbType = System.Data.DbType.Int32;
                idPartner.Size = 256;
                idPartner.Direction = System.Data.ParameterDirection.Input;
                idPartner.Value = adresa.PartnerId;
                command1.Parameters.Add(idPartner);

                SqlParameter idOras = new SqlParameter();
                idOras.ParameterName = "@CityId";
                idOras.DbType = System.Data.DbType.Int32;
                idOras.Size = 256;
                idOras.Direction = System.Data.ParameterDirection.Input;
                idOras.Value = adresa.Oras.CityId;
                command1.Parameters.Add(idOras);

                SqlParameter idJudet = new SqlParameter();
                idJudet.ParameterName = "@CountyId";
                idJudet.DbType = System.Data.DbType.Int32;
                idJudet.Size = 256;
                idJudet.Direction = System.Data.ParameterDirection.Input;
                idJudet.Value = adresa.County.CountyId;
                command1.Parameters.Add(idJudet);

                SqlParameter strada = new SqlParameter();
                strada.ParameterName = "@Street";
                strada.DbType = System.Data.DbType.String;
                strada.Size = 256;
                strada.Direction = System.Data.ParameterDirection.Input;
                strada.Value = adresa.Street;
                command1.Parameters.Add(strada);

                SqlParameter nr = new SqlParameter();
                nr.ParameterName = "@StreetNo";
                nr.DbType = System.Data.DbType.String;
                nr.Size = 256;
                nr.Direction = System.Data.ParameterDirection.Input;
                nr.Value = adresa.Number;
                command1.Parameters.Add(nr);

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
        public void DeleteAddress(int clientId)
        {
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command1 = new SqlCommand();
                command1.Connection = connection;
                command1.CommandType = System.Data.CommandType.Text;
                command1.CommandText = "delete from TPartnerAddress where PartnerId=@PartnerId";

                SqlParameter id = new SqlParameter();
                id.ParameterName = "@PartnerId";
                id.DbType = System.Data.DbType.Int32;
                id.Direction = System.Data.ParameterDirection.Input;
                id.Value = clientId;
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
        public void DeleteSelectedAddress(int adrId)
        {
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command1 = new SqlCommand();
                command1.Connection = connection;
                command1.CommandType = System.Data.CommandType.Text;
                command1.CommandText = "delete from TPartnerAddress where PartnerAddressId=@PartnerAddressId";

                SqlParameter id = new SqlParameter();
                id.ParameterName = "@PartnerAddressId";
                id.DbType = System.Data.DbType.Int32;
                id.Direction = System.Data.ParameterDirection.Input;
                id.Value = adrId;
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
        public void UpdateSelectedAddress(AddressModel adresa)
        {
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command1 = new SqlCommand("updateAddress", connection);
                command1.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter id = new SqlParameter();
                id.ParameterName = "@PartnerAddressId";
                id.DbType = System.Data.DbType.Int32;
                id.Direction = System.Data.ParameterDirection.Input;
                id.Value = adresa.PartnerAddressId;
                command1.Parameters.Add(id);

                SqlParameter cityId = new SqlParameter();
                cityId.ParameterName = "@CityId";
                cityId.DbType = System.Data.DbType.Int32;
                cityId.Direction = System.Data.ParameterDirection.Input;
                cityId.Value = adresa.Oras.CityId;
                command1.Parameters.Add(cityId);

                SqlParameter countyId = new SqlParameter();
                countyId.ParameterName = "@CountyId";
                countyId.DbType = System.Data.DbType.Int32;
                countyId.Direction = System.Data.ParameterDirection.Input;
                countyId.Value = adresa.County.CountyId;
                command1.Parameters.Add(countyId);

                SqlParameter str = new SqlParameter();
                str.ParameterName = "@Street";
                str.DbType = System.Data.DbType.String;
                str.Direction = System.Data.ParameterDirection.Input;
                str.Value = adresa.Street;
                command1.Parameters.Add(str);

                SqlParameter nr = new SqlParameter();
                nr.ParameterName = "@No";
                nr.DbType = System.Data.DbType.String;
                nr.Direction = System.Data.ParameterDirection.Input;
                nr.Value = adresa.Number;
                command1.Parameters.Add(nr);

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
        public DataTable GetCityNameById(int id)
        {
            DataTable adrese = new DataTable();
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select c.CityName from TCity c where CityId=@CityId";

                SqlParameter cityId = new SqlParameter();
                cityId.ParameterName = "@CityId";
                cityId.DbType = System.Data.DbType.Int32;
                cityId.Direction = System.Data.ParameterDirection.Input;
                cityId.Value = id;
                command.Parameters.Add(cityId);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(adrese);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return adrese;
        }
        public DataTable GetCountyNameById(int id)
        {
            DataTable adrese = new DataTable();
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select c.CountyName from TCounty c where CountyId=@CountyId";

                SqlParameter countyId = new SqlParameter();
                countyId.ParameterName = "@CountyId";
                countyId.DbType = System.Data.DbType.Int32;
                countyId.Direction = System.Data.ParameterDirection.Input;
                countyId.Value = id;
                command.Parameters.Add(countyId);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(adrese);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return adrese;
        }
        public DataTable GetClientAddresses(int clientId)
        {
            DataTable adrese = new DataTable();
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select i.PartnerId, i.PartnerAddressId, concat(p.PartnerName, ' ' , p.PartnerSurname) as NumePartener, " +
                    " concat(padr.StreetName, ', ', padr.StreetNo, ', '," +
                    " (select CityName from TCity where CityId = padr.CityId), ', ', " +
                    " (select CountyName from TCounty where CountyId = padr.CountyId)) as AdresaClient" +
                    " from TInvoice i" +
                    " join TPartner p on p.PartnerId = i.PartnerId" +
                    " join TPartnerAddress padr on padr.PartnerAddressId = i.PartnerAddressId where i.PartnerId=@ClientId";

                SqlParameter id = new SqlParameter();
                id.ParameterName = "@ClientId";
                id.DbType = System.Data.DbType.Int32;
                id.Direction = System.Data.ParameterDirection.Input;
                id.Value = clientId;
                command.Parameters.Add(id);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(adrese);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return adrese;
        }
        public DataTable GetClientAddressesById(int clientId, int addressId)
        {
            DataTable adrese = new DataTable();
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select i.PartnerId, i.PartnerAddressId, " +
                    " concat(padr.StreetName, ', ', padr.StreetNo, ', '," +
                    " (select CityName from TCity where CityId = padr.CityId), ', ', " +
                    " (select CountyName from TCounty where CountyId = padr.CountyId)) as AdresaClient" +
                    " from TInvoice i" +
                    " join TPartner p on p.PartnerId = i.PartnerId" +
                    " join TPartnerAddress padr on padr.PartnerAddressId = i.PartnerAddressId " +
                    "where i.PartnerId=@ClientId and i.PartnerAddressId=@AddressId";

                SqlParameter id = new SqlParameter();
                id.ParameterName = "@ClientId";
                id.DbType = System.Data.DbType.Int32;
                id.Direction = System.Data.ParameterDirection.Input;
                id.Value = clientId;
                command.Parameters.Add(id);

                SqlParameter idA = new SqlParameter();
                idA.ParameterName = "@AddressId";
                idA.DbType = System.Data.DbType.Int32;
                idA.Direction = System.Data.ParameterDirection.Input;
                idA.Value = addressId;
                command.Parameters.Add(idA);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(adrese);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return adrese;
        }
    }

}