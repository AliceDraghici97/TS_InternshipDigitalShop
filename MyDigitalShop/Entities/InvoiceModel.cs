using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class InvoiceModel
    {
        public InvoiceModel()
        {
            this.adresa = new AddressModel();
            this.client = new PartnerModel();
            this.user = new UserModel();
        }
       public int InvoiceId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public PartnerModel client { get; set; }
        public AddressModel adresa { get; set; }
        public UserModel user { get; set; }
        public string Observations { get; set; }
    }
}
