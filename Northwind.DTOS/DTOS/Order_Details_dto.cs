using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DTOS
{
    public class Order_Details_dto
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public short Quantity { get; set; }

    }
}
