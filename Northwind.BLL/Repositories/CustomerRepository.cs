using Northwind.DAL;
using Northwind.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL.Repositories
{
    public class CustomerRepository 
    {
        NorthwindEntities db = DbAyarlar.northwindDBinstance;
   

        public void Insert(Customer_dto item)
        {
            Customer cus = new Customer
            {
                CustomerID = item.CustomerID,
                CompanyName = item.CompanyName,
                ContactName = item.ContactName
            };
            db.Customers.Add(cus);
            db.SaveChanges();
        }

        public void Update(Customer_dto item)
        {
            Customer updated = db.Customers.Find(item.CustomerID);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }

        public void Delete(string itemId)
        {
            Customer deleted = db.Customers.Find(itemId);
            db.Customers.Remove(deleted);
            db.SaveChanges();
        }

        public List<Customer_dto> GetAll()
        {
            var cust = from c in db.Customers
                       select new Customer_dto()
                       {
                           CustomerID = c.CustomerID,
                           CompanyName = c.CompanyName,
                           ContactName = c.ContactName
                       };
            return cust.ToList();
        }

        public Customer_dto GetId(string itemId)
        {
            var item = db.Customers.Find(itemId);
            Customer_dto cus = new Customer_dto()
            {
                CustomerID = item.CustomerID,
                CompanyName = item.CompanyName,
                ContactName = item.ContactName
            };
            return cus;
        }
    }
}
