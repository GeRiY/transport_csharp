using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_2.Models
{
    public partial class address
    {
        public address(
            string city,
            int zipcode,
            string street_and_number,
            int isStorage)
        {
            this.city = city;
            this.zipcode = zipcode;
            this.street_and_number = street_and_number;
            this.is_storage = isStorage;
        }
    }
}
