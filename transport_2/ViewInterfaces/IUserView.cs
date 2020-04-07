using transport_2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_2.ViewInterfaces
{
    public interface IUserView
    {
        fos_user user { get; set; }
        string errorUsername { get; set; }
        string errorFirstName { get; set; }
        string errorLastName { get; set; }
        string errorRole { get; set; }
    }
}
