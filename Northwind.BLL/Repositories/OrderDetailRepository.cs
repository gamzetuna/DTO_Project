using Northwind.DAL;
using Northwind.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL.Repositories
{
    public class OrderDetailRepository
    {
        NorthwindEntities db = DbAyarlar.northwindDBinstance;
        public void Delete(int itemId, int itemId2)
        {
            Order_Detail deleted = db.Order_Details.Find(itemId, itemId2);
            db.Order_Details.Remove(deleted);
            db.SaveChanges();
        }

        public List<Order_Details_dto> GetAll()
        {

            var cust = from c in db.Order_Details
                       select new Order_Details_dto()
                       {
                           OrderID = c.OrderID,
                           ProductID = c.ProductID,                      
                           Quantity = c.Quantity
                       };
            return cust.ToList();

        }

        public Order_Details_dto GetId(int itemId,int itemId2)
        {
            var item = db.Order_Details.Find(itemId,itemId2); 
            Order_Details_dto cus = new Order_Details_dto()
            {
                OrderID = item.OrderID,
                ProductID = item.ProductID,
                Quantity = item.Quantity
               
            };
            return cus;
        }

        public void Insert(Order_Details_dto item)
        {
            Order_Detail cus = new Order_Detail
            {
                OrderID = item.OrderID,
                ProductID = item.ProductID,
                Quantity = item.Quantity
            };
            db.Order_Details.Add(cus);
            db.SaveChanges();
        }

        public void Update(Order_Details_dto item)
        {
            Order_Detail updated = db.Order_Details.Find(item.OrderID, item.ProductID);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
 

    }
}
