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
    public class BLAddress
    {
        public DataTable GetAddresses(int id)
        {
            DAAddress daAdrese = new DAAddress();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = daAdrese.GetAddresses(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dataTable;
        }
        public List<CityModel> GetCities()
        {
            List<CityModel> listaOrase = new List<CityModel>();
            DAAddress daAdrese = new DAAddress();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = daAdrese.GetCities();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                CityModel oras = new CityModel();
                oras.CityId = Convert.ToInt32(dataTable.Rows[i]["CityId"]);
                oras.CityName = dataTable.Rows[i]["CityName"].ToString();
                listaOrase.Add(oras);
            }
            return listaOrase;
        }
        public List<CountyModel> GetCounties()
        {
            List<CountyModel> lista = new List<CountyModel>();
            DAAddress daAdrese = new DAAddress();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = daAdrese.GetCounties();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                CountyModel jud = new CountyModel();
                jud.CountyId = Convert.ToInt32(dataTable.Rows[i]["CountyId"]);
                jud.CountyName = dataTable.Rows[i]["CountyName"].ToString();
                lista.Add(jud);
            }
            return lista;
        }
        public void InsertAdress(AddressModel adresa, out bool status, out string message)
        {
            message = "OK";
            status = false;
            try
            {
                DAAddress daAdresa = new DAAddress();
                daAdresa.InsertAddress(adresa);
                DataTable dataTable2 = daAdresa.GetAddresses(adresa.PartnerId);
                message = "Adresa adaugata!";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void DeleteSelectedAddress(int id, out string errorMessage)
        {
            errorMessage = "OK";
            DAAddress daADR = new DAAddress();
            daADR.DeleteSelectedAddress(id);
            errorMessage = "Adresa stearsa!";
        }
        public void DeleteAllAddresses(int id, out string errorMessage)
        {
            errorMessage = "OK";
            DAAddress daADR = new DAAddress();
            daADR.DeleteAddress(id);
            errorMessage = "Adrese stearsa!";
        }
        public void UpdateSelectedAddress(AddressModel adresaNoua, out string errorMessage)
        {
            errorMessage = "OK";
            DAAddress daAdr = new DAAddress();
            daAdr.UpdateSelectedAddress(adresaNoua);
            errorMessage = "Adresa modificata!";
        }
        public DataTable GetCityNameById(int id)
        {
            DAAddress daAdrese = new DAAddress();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = daAdrese.GetCityNameById(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dataTable;
        }
        public DataTable GetCountyNameById(int id)
        {
            DAAddress daAdrese = new DAAddress();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = daAdrese.GetCountyNameById(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dataTable;
        }
        public DataTable GetClientAddresses(int clientId)
        {
            DAAddress daAdrese = new DAAddress();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = daAdrese.GetClientAddresses(clientId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dataTable;
        }
        public DataTable GetClientAddressesById(int clientId, int adrId)
        {
            DAAddress daAdrese = new DAAddress();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = daAdrese.GetClientAddressesById(clientId, adrId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dataTable;
        }
    }
}
