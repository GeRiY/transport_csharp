using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_2.ViewInterfaces
{
    interface IDataGridList<G>
    {
        BindingList<G> bindingList { get; set; }
        int pageNumber { get; set; }
        int itemsPerPage { get; set; }
        string search { get; }
        string sortBy { get; set; }
        bool ascending { get; set; }
        int totalItems { set; }
    }
}
