using Northwind.DAL;
using Northwind.DTOS.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL.Repositories
{
    public class ProductRepository : IRepository<Product_dto>
    {
        NorthwindEntities db = DbAyarlar.northwindDBinstance;

        public void Delete(int itemId)
        {
            Product deleted = db.Products.Find(itemId);
            db.Products.Remove(deleted);
            db.SaveChanges();
        }

        public List<Product_dto> GetAll()
        {
            List<Product> pro = new List<Product>();
            pro = db.Products.ToList();
            List<Product_dto> prodto = new List<Product_dto>();
            foreach (var item in pro)
            {
                prodto.Add(new Product_dto
                {
                   ProductID = item.ProductID,
                   ProductName = item.ProductName,
                   QuantityPerUnit = item.QuantityPerUnit,
                   UnitPrice = item.UnitPrice,
                   UnitsInStock = item.UnitsInStock

                });
            }
            return prodto;
        }

        public Product_dto GetId(int itemId)
        {
            Product_dto prodto = new Product_dto();
            var item = db.Products.Find(itemId);
            prodto.ProductID = item.ProductID;
            prodto.ProductName = item.ProductName;
            prodto.QuantityPerUnit = item.QuantityPerUnit;
            prodto.UnitPrice = item.UnitPrice;
            prodto.UnitsInStock = item.UnitsInStock;

            return prodto;
        }

        public void Insert(Product_dto item)
        {
            Product pro = new Product
            {
                ProductName = item.ProductName,
                QuantityPerUnit = item.QuantityPerUnit,
                UnitPrice = item.UnitPrice,
                UnitsInStock = item.UnitsInStock
            };
            db.Products.Add(pro);
            db.SaveChanges();
        }

        public void Update(Product_dto item)
        {
            Product updated = db.Products.Find(item.ProductID);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
