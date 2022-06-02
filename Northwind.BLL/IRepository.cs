using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL
{
    public  interface IRepository<T> //generic type
    {
        List<T> GetAll();
        T GetId(int itemId);
        void Insert(T item);
        void Update(T item);
        void Delete(int itemId);
    }
}
