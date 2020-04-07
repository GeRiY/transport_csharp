using transport_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_2.ViewInterfaces
{
    public interface IPackageView
    {
        package pack { get; set; }
        string errorTargetAddress { get; set; }
        string errorPackageStatus { get; set; }
        string errorTransferStatus { get; set; }
        string errorHandler { get; set; }
        string errorOwner { get; set; }
        string errorWidth { get; set; }
        string errorHeight { get; set; }
        string errorLength { get; set; }
    }
}
