using Northwind.DAL;
using Northwind.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL.Repositories
{
    public class SupplierRepository : IRepository<Suppplier_dto>
    {
        NorthwindEntities db = DbAyarlar.northwindDBinstance;

        public void Delete(int itemId)
        {
            Supplier deleted = db.Suppliers.Find(itemId);
            db.Suppliers.Remove(deleted);
            db.SaveChanges();
        }

        public List<Suppplier_dto> GetAll()
        {
            List<Supplier> sup = new List<Supplier>();
            sup = db.Suppliers.ToList();
            List<Suppplier_dto> supdto = new List<Suppplier_dto>();
            foreach (var item in sup)
            {
                supdto.Add(new Suppplier_dto
                {
                    SuplierID = item.SupplierID,
                    CompanyName = item.CompanyName,
                    ContactName = item.ContactName

                });
            }
            return supdto;
        }

        public Suppplier_dto GetId(int itemId)
        {
            var item = db.Suppliers.Find(itemId);

            Suppplier_dto supdto = new Suppplier_dto()
                {
                    SuplierID = item.SupplierID,
                    CompanyName = item.CompanyName,
                    ContactName = item.ContactName
                };
            
            return supdto;
        }

        public void Insert(Suppplier_dto item)
        {
            Supplier sup = new Supplier
            {
                CompanyName = item.CompanyName,
                ContactName = item.ContactName
            };
            db.Suppliers.Add(sup);
            db.SaveChanges();
        }

        public void Update(Suppplier_dto item)
        {
            Supplier updated = db.Suppliers.Find(item.SuplierID);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
