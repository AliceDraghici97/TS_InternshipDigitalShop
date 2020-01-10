using Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class DAClients
    {
        public DataTable GetClients()
        {
            DataTable clienti = new DataTable();
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select PartnerId, PartnerName, PartnerSurname, PartnerCode, PhoneNo, Email" +
                    " from TPartner";
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(clienti);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return clienti;
        }
        public DataTable FiltrareClienti(string numeF, string prenumeF, string codF, string telF)
        {
            DataTable clienti = new DataTable();
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand("filtrareParteneri", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter nume = new SqlParameter();
                nume.ParameterName = "@PartnerName";
                nume.DbType = System.Data.DbType.String;
                nume.Direction = System.Data.ParameterDirection.Input;
                nume.Value = numeF;
                command.Parameters.Add(nume);

                SqlParameter prenume = new SqlParameter();
                prenume.ParameterName = "@PartnerSurname";
                prenume.DbType = System.Data.DbType.String;
                prenume.Direction = System.Data.ParameterDirection.Input;
                prenume.Value = prenumeF;
                command.Parameters.Add(prenume);

                SqlParameter cod = new SqlParameter();
                cod.ParameterName = "@PartnerCode";
                cod.DbType = System.Data.DbType.String;
                cod.Direction = System.Data.ParameterDirection.Input;
                cod.Value = codF;
                command.Parameters.Add(cod);

                SqlParameter telefon = new SqlParameter();
                telefon.ParameterName = "@PhoneNo";
                telefon.DbType = System.Data.DbType.String;
                telefon.Direction = System.Data.ParameterDirection.Input;
                telefon.Value = telF;
                command.Parameters.Add(telefon);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(clienti);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return clienti;
        }
        public void InsertClient(string nume, string prenume, string cod, string tel, string email)
        {
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command1 = new SqlCommand("insertPartner", connection);
                command1.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter numeP = new SqlParameter();
                numeP.ParameterName = "@PartnerName";
                numeP.DbType = System.Data.DbType.String;
                numeP.Size = 256;
                numeP.Direction = System.Data.ParameterDirection.Input;
                numeP.Value = nume;
                command1.Parameters.Add(numeP);
                               
                SqlParameter prenumeP = new SqlParameter();
                prenumeP.ParameterName = "@PartnerSurname";
                prenumeP.DbType = System.Data.DbType.String;
                prenumeP.Size = 256;
                prenumeP.Direction = System.Data.ParameterDirection.Input;
                prenumeP.Value = prenume;
                command1.Parameters.Add(prenumeP);

                SqlParameter codP = new SqlParameter();
                codP.ParameterName = "@PartnerCode";
                codP.DbType = System.Data.DbType.String;
                codP.Size = 256;
                codP.Direction = System.Data.ParameterDirection.Input;
                codP.Value = cod;
                command1.Parameters.Add(codP);

                SqlParameter telP = new SqlParameter();
                telP.ParameterName = "@PhoneNo";
                telP.DbType = System.Data.DbType.String;
                telP.Size = 256;
                telP.Direction = System.Data.ParameterDirection.Input;
                telP.Value = tel;
                command1.Parameters.Add(telP);

                SqlParameter emailP = new SqlParameter();
                emailP.ParameterName = "@Email";
                emailP.DbType = System.Data.DbType.String;
                emailP.Size = 256;
                emailP.Direction = System.Data.ParameterDirection.Input;
                emailP.Value = email;
                command1.Parameters.Add(emailP);

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
        public DataTable CheckClient(string nume, string prenume, string cod)
        {
            DataTable clienti = new DataTable();
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select PartnerId, PartnerName, PartnerSurname, PartnerCode, PhoneNo, Email" +
                    " from TPartner where PartnerName=@PartnerName and PartnerSurname=@PartnerSurname and PartnerCode=@PartnerCode";

                SqlParameter numeP = new SqlParameter();
                numeP.ParameterName = "@PartnerName";
                numeP.DbType = System.Data.DbType.String;
                numeP.Size = 256;
                numeP.Direction = System.Data.ParameterDirection.Input;
                numeP.Value = nume;
                command.Parameters.Add(numeP);

                SqlParameter prenumeP = new SqlParameter();
                prenumeP.ParameterName = "@PartnerSurname";
                prenumeP.DbType = System.Data.DbType.String;
                prenumeP.Size = 256;
                prenumeP.Direction = System.Data.ParameterDirection.Input;
                prenumeP.Value = prenume;
                command.Parameters.Add(prenumeP);

                SqlParameter codP = new SqlParameter();
                codP.ParameterName = "@PartnerCode";
                codP.DbType = System.Data.DbType.String;
                codP.Size = 256;
                codP.Direction = System.Data.ParameterDirection.Input;
                codP.Value = cod;
                command.Parameters.Add(codP);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(clienti);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return clienti;
        }
        public DataTable SelectPartnerId(string nume, string prenume, string cod)
        {
            DataTable clienti = new DataTable();
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select PartnerId" +
                    " from TPartner where PartnerName=@PartnerName and PartnerSurname=@PartnerSurname and PartnerCode=@PartnerCode";

                SqlParameter numeP = new SqlParameter();
                numeP.ParameterName = "@PartnerName";
                numeP.DbType = System.Data.DbType.String;
                numeP.Size = 256;
                numeP.Direction = System.Data.ParameterDirection.Input;
                numeP.Value = nume;
                command.Parameters.Add(numeP);

                SqlParameter prenumeP = new SqlParameter();
                prenumeP.ParameterName = "@PartnerSurname";
                prenumeP.DbType = System.Data.DbType.String;
                prenumeP.Size = 256;
                prenumeP.Direction = System.Data.ParameterDirection.Input;
                prenumeP.Value = prenume;
                command.Parameters.Add(prenumeP);

                SqlParameter codP = new SqlParameter();
                codP.ParameterName = "@PartnerCode";
                codP.DbType = System.Data.DbType.String;
                codP.Size = 256;
                codP.Direction = System.Data.ParameterDirection.Input;
                codP.Value = cod;
                command.Parameters.Add(codP);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(clienti);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return clienti;
        }
        public void UpdateClient(PartnerModel client)
        {
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command1 = new SqlCommand("updateClient", connection);
                command1.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter id = new SqlParameter();
                id.ParameterName = "@PartnerId";
                id.DbType = System.Data.DbType.Int32;                
                id.Direction = System.Data.ParameterDirection.Input;
                id.Value = client.ClientId;
                command1.Parameters.Add(id);

                SqlParameter numeP = new SqlParameter();
                numeP.ParameterName = "@PartnerName";
                numeP.DbType = System.Data.DbType.String;
                numeP.Size = 256;
                numeP.Direction = System.Data.ParameterDirection.Input;
                numeP.Value = client.Nume;
                command1.Parameters.Add(numeP);

                SqlParameter prenumeP = new SqlParameter();
                prenumeP.ParameterName = "@PartnerSurname";
                prenumeP.DbType = System.Data.DbType.String;
                prenumeP.Size = 256;
                prenumeP.Direction = System.Data.ParameterDirection.Input;
                prenumeP.Value = client.Prenume;
                command1.Parameters.Add(prenumeP);

                SqlParameter codP = new SqlParameter();
                codP.ParameterName = "@PartnerCode";
                codP.DbType = System.Data.DbType.String;
                codP.Size = 256;
                codP.Direction = System.Data.ParameterDirection.Input;
                codP.Value = client.CodClient;
                command1.Parameters.Add(codP);

                SqlParameter telP = new SqlParameter();
                telP.ParameterName = "@PhoneNo";
                telP.DbType = System.Data.DbType.String;
                telP.Size = 256;
                telP.Direction = System.Data.ParameterDirection.Input;
                telP.Value = client.Telefon;
                command1.Parameters.Add(telP);

                SqlParameter emailP = new SqlParameter();
                emailP.ParameterName = "@Email";
                emailP.DbType = System.Data.DbType.String;
                emailP.Size = 256;
                emailP.Direction = System.Data.ParameterDirection.Input;
                emailP.Value = client.Email;
                command1.Parameters.Add(emailP);

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
        public void DeleteClient(int clientId)
        {
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command1 = new SqlCommand();
                command1.Connection = connection;
                command1.CommandType = System.Data.CommandType.Text;
                command1.CommandText = "delete from TPartner where PartnerId=@PartnerId";

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
        public DataTable GetClientById(int clientId)
        {
            DataTable clienti = new DataTable();
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select concat(PartnerName, ' ', PartnerSurname) as NumeClient" +
                    " from TPartner where PartnerId=@ClientId";

                SqlParameter id = new SqlParameter();
                id.ParameterName = "@ClientId";
                id.DbType = System.Data.DbType.Int32;
                id.Direction = System.Data.ParameterDirection.Input;
                id.Value = clientId;
                command.Parameters.Add(id);
             
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(clienti);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return clienti;
        }
    }
}

