using Northwind.DAL;
using Northwind.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BLL.Repositories
{
    public class EmployeeRepository : IRepository<Employee_dto>
    {
        NorthwindEntities db = DbAyarlar.northwindDBinstance;

        public void Delete(int itemId)
        {
            Employee deleted = db.Employees.Find(itemId);
            db.Employees.Remove(deleted);
            db.SaveChanges();
        }

        public List<Employee_dto> GetAll()
        {
            List<Employee> emp = new List<Employee>();
            emp = db.Employees.ToList();
            List<Employee_dto> empdto = new List<Employee_dto>();
            foreach (var item in emp)
            {
                empdto.Add(new Employee_dto
                {
                    EmployeeID = item.EmployeeID,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    BirthDate = Convert.ToDateTime(item.BirthDate)

                });

            }
            return empdto;

        }

        public Employee_dto GetId(int itemId)
        {
            Employee_dto empdto = new Employee_dto();
            var item = db.Employees.Find(itemId);
            empdto.EmployeeID = item.EmployeeID;
            empdto.FirstName = item.FirstName;
            empdto.LastName = item.LastName;
            empdto.BirthDate = Convert.ToDateTime(item.BirthDate);
            return empdto;
        }

        public void Insert(Employee_dto item)
        {
            Employee emp1 = new Employee
            {
                FirstName = item.FirstName,
                LastName = item.LastName,
                BirthDate = item.BirthDate
            };
            db.Employees.Add(emp1);
            db.SaveChanges();
        }

        public void Update(Employee_dto item)
        {
            Employee updated = db.Employees.Find(item.EmployeeID);
            db.Entry(updated).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
