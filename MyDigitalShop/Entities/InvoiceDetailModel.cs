using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class InvoiceDetailModel
    {
        public InvoiceDetailModel()
        {
            this.Factura = new InvoiceModel();
            this.Articol = new ItemModel();
        }
        public int InvoiceDetailId { get; set; }
        public InvoiceModel Factura { get; set; }
        public ItemModel Articol { get; set; }
        public decimal Qtty { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        public string Observations { get; set; }
    }
}
