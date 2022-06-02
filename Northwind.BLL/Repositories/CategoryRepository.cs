using Northwind.DAL;
using Northwind.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL.Repositories
{
    public class CategoryRepository : IRepository<Category_dto> 
    {
        NorthwindEntities db = DbAyarlar.northwindDBinstance;

       public void Insert(Category_dto item)
        {
            Category cat = new Category
            {
                CategoryName = item.KategoriAdi,
                Description = item.Descriptions
            };
            db.Categories.Add(cat);
            db.SaveChanges();
        }    
        public void Update(Category_dto item)
        {
            Category updated = db.Categories.Find(item.KategoriId);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }

        public List<Category_dto> GetAll()
        {
            List<Category> cat = new List<Category>();
            cat = db.Categories.ToList();
            List<Category_dto> catdto = new List<Category_dto>();
            foreach(var item in cat)
            {
                catdto.Add(new Category_dto
                {
                    KategoriId = item.CategoryID,
                    KategoriAdi = item.CategoryName,
                    Descriptions = item.Description

                });
            }
            return catdto;
        }

        public Category_dto GetId(int itemId)
        {
            Category_dto catdto = new Category_dto();
            var item = db.Categories.Find(itemId);
            catdto.KategoriId = item.CategoryID;
            catdto.KategoriAdi = item.CategoryName;
            catdto.Descriptions = item.Description;
            return catdto;
            
        }

        public void Delete(int itemId)
        {
            Category deleted = db.Categories.Find(itemId);
            db.Categories.Remove(deleted);
            db.SaveChanges();

        }
    }
}
