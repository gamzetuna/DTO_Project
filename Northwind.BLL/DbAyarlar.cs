using Northwind.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL
{
    public class DbAyarlar
    {
       private static NorthwindEntities _northwindDBInstance;

        public static NorthwindEntities northwindDBinstance
        {
            get
            {
                if ( _northwindDBInstance == null)
                {
                    _northwindDBInstance = new NorthwindEntities();
                }
                return _northwindDBInstance;
            }
        }
    }
}
