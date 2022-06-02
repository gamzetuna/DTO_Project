using Northwind.DAL;
using Northwind.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL.Repositories
{
    public class ShipperRepository :IRepository<Shipper_dto>
    {
        NorthwindEntities db = DbAyarlar.northwindDBinstance;

        public void Delete(int itemId)
        {
            Shipper deleted = db.Shippers.Find(itemId);
            db.Shippers.Remove(deleted);
            db.SaveChanges();
        }

        public List<Shipper_dto> GetAll()
        {
            List<Shipper> shp = new List<Shipper>();
            shp = db.Shippers.ToList();
            List<Shipper_dto> shpdto = new List<Shipper_dto>();
            foreach (var item in shp)
            {
                shpdto.Add(new Shipper_dto
                {
                    ShipID= item.ShipperID,
                    CompanyName = item.CompanyName,
                    Phone = item.Phone

                });
            }
            return shpdto;
        }

        public Shipper_dto GetId(int itemId)
        {
            Shipper_dto shpdto = new Shipper_dto();
            var item = db.Shippers.Find(itemId);
            shpdto.ShipID = item.ShipperID;
            shpdto.CompanyName = item.CompanyName;
            shpdto.Phone = item.Phone;
            return shpdto;
        }

        public void Insert(Shipper_dto item)
        {
            Shipper shp = new Shipper
            {
                CompanyName = item.CompanyName,
                Phone = item.Phone
            };
            db.Shippers.Add(shp);
            db.SaveChanges();
        }

        public void Update(Shipper_dto item)
        {
            Shipper updated = db.Shippers.Find(item.ShipID);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }

    }
}
