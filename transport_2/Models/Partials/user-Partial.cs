using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_2.Models
{
    public partial class fos_user
    {
        public fos_user(
            string username,
            string fisrtName,
            string lastName,
            int role)
        {
            this.username = username;
            this.first_name = fisrtName;
            this.last_name = lastName;
            this.role = role;
        }
    }
}
