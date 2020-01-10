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
    public class BLClients
    {
        public DataTable GetClient()
        {
            DAClients daClienti = new DAClients();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = daClienti.GetClients();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dataTable;
        }
        public DataTable FiltrareClienti(string nume, string prenume, string cod, string tel)
        {
            DAClients daClienti = new DAClients();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = daClienti.FiltrareClienti(nume, prenume, cod, tel);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dataTable;
        }
        public void InsertUser(string nume, string prenume, string cod, string tel, string email, out bool status, out string errorMessage)
        {
            status = false;
            errorMessage = "OK";

            DAClients daClients = new DAClients();
            DataTable dataTable = daClients.CheckClient(nume, prenume, cod);

            if (dataTable.Rows.Count == 1)
            {
                status = true;
                errorMessage = "Client existent";
            }
            else
            {
                daClients.InsertClient(nume, prenume, cod, tel, email);
                DataTable dataTable2 = daClients.CheckClient(nume, prenume, cod);

                if (dataTable2.Rows.Count == 1)
                {
                    status = false;
                    errorMessage = "Client adaugat!";
                }
            }
        }
        public int SelectPartnerId(string nume, string prenume, string cod)
        {
            DAClients daClienti = new DAClients();
            DataTable dataTable = new DataTable();
            int id = -1;
            try
            {
                dataTable = daClienti.SelectPartnerId(nume, prenume, cod);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                id = Convert.ToInt32(dataTable.Rows[i]["PartnerId"]);
            }
            return id;
        }
        public void UpdateClient(PartnerModel clientNou, out string errorMessage)
        {
            errorMessage = "OK";

            DAClients daClients = new DAClients();
            daClients.UpdateClient(clientNou);
            errorMessage = "Client modificat!";
        }
        public void DeleteClient(int id, out string errorMessage)
        {
            errorMessage = "OK";
            DAAddress daADR = new DAAddress();
            daADR.DeleteAddress(id);

            DAClients daClients = new DAClients();
            daClients.DeleteClient(id);            
            errorMessage = "Client sters!";
        }
        public DataTable GetClientById(int clientId)
        {
            DAClients daClienti = new DAClients();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = daClienti.GetClientById(clientId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dataTable;
        }

    }
}