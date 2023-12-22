using Microsoft.EntityFrameworkCore;
using PersonalApp.Domains.Concrete;
using PersonnelApp.DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL.Repositories.Concrete
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(PersonnelContext context):base(context) 
        {
            
        }
        public IEnumerable<Department> GetDepartmentsWithPersonnels()
        {
           return PersonnelContext.Departments.Include("Personnels").ToList();
        }

        public IEnumerable<Department> GetTopDepartment(int count)
        {
            return PersonnelContext.Departments.Take(count);
        }
        public PersonnelContext PersonnelContext { get { return _dbContext as PersonnelContext; } }
    }
}
