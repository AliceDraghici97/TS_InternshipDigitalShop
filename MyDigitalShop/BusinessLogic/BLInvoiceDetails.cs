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
    public class BLInvoiceDetails
    {
        public void InsertInvoiceDetail(InvoiceDetailModel det, out bool status, out string errorMessage)
        {
            status = false;
            errorMessage = "OK";
            DAInvoiceDetails da = new DAInvoiceDetails();
            da.InsertInvoiceDetail(det);

            errorMessage = "Detaliu adaugat!";
        }
        public void UpdateInvoiceDetail(InvoiceDetailModel det, out bool status, out string errorMessage)
        {
            status = false;
            errorMessage = "OK";
            DAInvoiceDetails da = new DAInvoiceDetails();
            da.UpdateInvoiceDetail(det);

            errorMessage = "Detaliu modificat!";
        }
        public void DeleteSelectedDetail(int idDetaliu, out string errorMessage)
        {
            errorMessage = "OK";
            DAInvoiceDetails daInvoiceDet = new DAInvoiceDetails();
            daInvoiceDet.DeleteSelectedDetail(idDetaliu);
            errorMessage = "Detaliu Sters!";
        }
        public void DeleteAllDetails(int idFactura, out string errorMessage)
        {
            errorMessage = "OK";
            DAInvoiceDetails daInvoiceDet = new DAInvoiceDetails();
            daInvoiceDet.DeleteAllDetails(idFactura);
            errorMessage = "Detaliu Sters!";
        }
        public DataTable GetDetails(int id)
        {
            DAInvoiceDetails detalii = new DAInvoiceDetails();
            DataTable dataTable = new DataTable();
            try
            {
                dataTable = detalii.GetDetails(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dataTable;
        }
    }
}