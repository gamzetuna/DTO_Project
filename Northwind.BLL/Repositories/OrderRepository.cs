using Northwind.DAL;
using Northwind.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL.Repositories
{
    public class OrderRepository:IRepository<Order_dto>
    {
        NorthwindEntities db = DbAyarlar.northwindDBinstance;

        public void Delete(int itemId)
        {
            Order deleted = db.Orders.Find(itemId);
            db.Orders.Remove(deleted);
            db.SaveChanges();
        }

        public List<Order_dto> GetAll()
        {
            var or = from c in db.Orders
                       select new Order_dto()
                       {
                           OrderId = c.OrderID,
                           ShipName = c.ShipName,
                           ShipAddress = c.ShipAddress
                           
                       };
            return or.ToList();
        }

        public Order_dto GetId(int itemId)
        {
            var item = db.Orders.Find(itemId);
            Order_dto cus = new Order_dto()
            {
                OrderId = item.OrderID,
                ShipName = item.ShipName,
                ShipAddress = item.ShipAddress

            };
            return cus;
        }

        public void Insert(Order_dto item)
        {
            Order cus = new Order
            {
                ShipName = item.ShipName,
                ShipAddress = item.ShipAddress
            };
            db.Orders.Add(cus);
            db.SaveChanges();
        }

        public void Update(Order_dto item)
        {
            Order updated = db.Orders.Find(item.OrderId);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
