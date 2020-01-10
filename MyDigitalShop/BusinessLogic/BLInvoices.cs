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
    public class BLInvoices
    {
        public DataTable GetInvoices(int userId)
        {
            DAInvoices daFacturi = new DAInvoices();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = daFacturi.GetInvoices(userId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dataTable;
        }
        public DataTable GetInvoicesById(int clientId)
        {
            DAInvoices daFacturi = new DAInvoices();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = daFacturi.GetInvoicesById(clientId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dataTable;
        }
        public void InsertInvoice(InvoiceModel factura, out bool status, out string errorMessage)
        {
            status = false;
            errorMessage = "OK";
            DAInvoices daFacturi = new DAInvoices();
            daFacturi.InsertInvoice(factura);

            errorMessage = "Factura adaugata!";
        }
        public void UpdateInvoice(InvoiceModel factura, out bool status, out string errorMessage)
        {
            status = false;
            errorMessage = "OK";
            DAInvoices daFacturi = new DAInvoices();
            daFacturi.UpdateInvoice(factura);
            errorMessage = "Factura adaugata!";
        }
        public void DeleteInvoice(int id, out string errorMessage)
        {
            errorMessage = "OK";
            DAInvoices daInvoices = new DAInvoices();
            daInvoices.DeleteInvoice(id);
            errorMessage = "Factura stearsa!";
        }

    }
}



