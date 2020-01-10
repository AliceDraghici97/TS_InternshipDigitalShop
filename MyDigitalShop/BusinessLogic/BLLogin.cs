using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class BLLogin
    {      
        public BLLogin() { }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public UserModel CheckUser(string userName, string password, out bool status, out string errorMessage)
        {
            UserModel user = new UserModel();
            status = false;

            DALogin daLogin = new DALogin();
            DataTable dataTable = daLogin.CheckUsers(userName);
            errorMessage = "";

            if (dataTable.Rows.Count == 0)
            {
                status = false;
                errorMessage = "Utilizator inexistent";
            }
            else
            {
                for(int i = 0; i < dataTable.Rows.Count; i++)
                {
                   if(password == Base64Decode(dataTable.Rows[i]["UserPassword"].ToString()))
                   {
                        user.UserId = Convert.ToInt32(dataTable.Rows[i]["UserId"]);
                        user.UserName = Convert.ToString(dataTable.Rows[i]["UserName"]);
                        user.UserPassword = Convert.ToString(dataTable.Rows[i]["UserPassword"]);
                        user.LastLogin = DateTime.Now;
                        status = true;
                        errorMessage = "Logare reusita!";
                        daLogin.UpdateLastLogin(userName);
                   }
                   else
                   {
                        errorMessage = "Parola incorecta!";
                   }
                }
            }
            return user;
        }

        public void InsertUser(string userName, string password, out bool status, out string errorMessage)
        {
            UserModel user = new UserModel();
            status = false;
            errorMessage = "OK";

            DALogin daLogin = new DALogin();
            DataTable dataTable = daLogin.CheckUsers(userName);

            if (dataTable.Rows.Count == 1)
            {
                status = true;
                errorMessage = "Utilizator existent";
            }
            else
            {
                daLogin.InsertUser(userName, Base64Encode(password));                
                DataTable dataTable2 = daLogin.CheckUsers(userName);

                if (dataTable2.Rows.Count == 1)
                {
                    status = false;
                    errorMessage = "Utilizator adaugat!";
                }
            }            
        }
    }
}
