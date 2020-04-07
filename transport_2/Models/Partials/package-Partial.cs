using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transport_2.Models
{
    public partial class package
    {
        public package(
            int target_address,
            int package_status,
            int transfer_status,
            int handler,
            int owner,
            int width,
            int height,
            int length)
        {
            this.target_address = target_address;
            this.package_status = package_status;
            this.transfer_status = transfer_status;
            this.handler = handler;
            this.owner = owner;
            this.width = width;
            this.height = height;
            this.length = length;
        }
    }
}
