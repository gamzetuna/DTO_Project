using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DTOS
{
    public class Order_dto
    {
        public int OrderId { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
    }
}
