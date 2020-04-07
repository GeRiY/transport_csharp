using transport_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_2.ViewInterfaces
{
    public interface IAddressView
    {
        address address { get; set; }
        string errorCity { get; set; }
        string errorZipCode { get; set; }
        string errorStreetAndNumber { get; set; }
        string errorIsStorage { get; set; }
    }
}
