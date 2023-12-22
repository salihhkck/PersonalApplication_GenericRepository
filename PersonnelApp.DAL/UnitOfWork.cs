using PersonnelApp.DAL.Repositories.Abstract;
using PersonnelApp.DAL.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private PersonnelContext _personnelcontext;
        public UnitOfWork(PersonnelContext context)
        {
            _personnelcontext = context;

            DepartmentRepository= new DepartmentRepository(_personnelcontext);

            PersonnelRepository= new PersonnelRepository(_personnelcontext);
        }
        public IDepartmentRepository DepartmentRepository { get; private set; }

        public IPersonnelRepository PersonnelRepository { get; private set; }

        public int Complete()
        {
            return _personnelcontext.SaveChanges();
        }

        public void Dispose()
        {
             _personnelcontext.Dispose();
        }
    }
}
