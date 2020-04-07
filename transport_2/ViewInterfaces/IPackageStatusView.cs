using transport_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_2.ViewInterfaces
{
    public interface IPackageStatusView
    {
        package_status packageStatus { get; set; }
        string errorName { get; set; }
    }
}
