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
    public class DALogin
    {
        public DALogin() { }

        public DataTable CheckUsers(string userName)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "select UserId,UserName,UserPassword" +
                    " from TERPUser where UserName=@UserName";
                SqlParameter parameter = new SqlParameter();
                parameter.ParameterName = "@UserName";
                parameter.DbType = System.Data.DbType.String;
                parameter.Size = 256;
                parameter.Direction = System.Data.ParameterDirection.Input;
                parameter.Value = userName;
                command.Parameters.Add(parameter);
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dataTable;
        }

        public void UpdateLastLogin(string userName)
        {
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand commandUPD = new SqlCommand();
                commandUPD.Connection = connection;
                commandUPD.CommandType = System.Data.CommandType.Text;
                commandUPD.CommandText = "update TERPUser " +
                    "set LastLogin=@LastLogin where UserName=@UserName;";
                SqlParameter parameterUPD = new SqlParameter();
                parameterUPD.ParameterName = "@LastLogin";
                parameterUPD.DbType = System.Data.DbType.DateTime;
                parameterUPD.Direction = System.Data.ParameterDirection.Input;
                parameterUPD.Value = DateTime.Now;
                commandUPD.Parameters.Add(parameterUPD);

                SqlParameter username = new SqlParameter();
                username.ParameterName = "@UserName";
                username.DbType = System.Data.DbType.String;
                username.Direction = System.Data.ParameterDirection.Input;
                username.Value = userName;
                commandUPD.Parameters.Add(username); 

                SqlDataAdapter adapterUPD = new SqlDataAdapter();
                adapterUPD.UpdateCommand = commandUPD;
                adapterUPD.UpdateCommand.ExecuteNonQuery();
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

        public void InsertUser(string userName, string password)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = new SqlConnection(Properties.Resources.ConnectionString);
            try
            {
                connection.Open();

                SqlCommand command1 = new SqlCommand("insertUser", connection);
                command1.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter userNameParm = new SqlParameter();
                userNameParm.ParameterName = "@UserName";
                userNameParm.DbType = System.Data.DbType.String;
                userNameParm.Size = 256;
                userNameParm.Direction = System.Data.ParameterDirection.Input;
                userNameParm.Value = userName;
                command1.Parameters.Add(userNameParm);

                SqlParameter passwordParm = new SqlParameter();
                passwordParm.ParameterName = "@UserPassword";
                passwordParm.DbType = System.Data.DbType.String;
                passwordParm.Size = 256;
                passwordParm.Direction = System.Data.ParameterDirection.Input;
                passwordParm.Value = password;
                command1.Parameters.Add(passwordParm);

                SqlParameter lastLoginParam = new SqlParameter();
                lastLoginParam.ParameterName = "@LastLogin";
                lastLoginParam.DbType = System.Data.DbType.DateTime;
                lastLoginParam.Direction = System.Data.ParameterDirection.Input;
                lastLoginParam.Value = DateTime.Now;
                command1.Parameters.Add(lastLoginParam);

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
    }
}