using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AddressModel
    {
        public AddressModel()
        {
            this.County = new CountyModel();
            this.Oras = new CityModel();
        }

        public string Street { get; set; }
        
        public string Number { get; set; }

        public CityModel Oras { get; set; }

        public CountyModel County { get; set; }

        public int PartnerId { get; set; }

        public int PartnerAddressId { get; set; }
    }
}
