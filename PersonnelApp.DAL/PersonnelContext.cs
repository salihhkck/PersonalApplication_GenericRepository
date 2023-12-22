using Microsoft.EntityFrameworkCore;
using PersonalApp.Domains.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnelApp.DAL
{
    public class PersonnelContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=SALIH\SQLEXPRESS;Database=PersonnelApp;Trusted_Connection=True; TrustServerCertificate=True;");
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Personnel> Personnels { get; set; }
    }
}
