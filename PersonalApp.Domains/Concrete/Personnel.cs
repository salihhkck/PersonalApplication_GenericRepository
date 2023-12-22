using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp.Domains.Concrete
{
    public class Personnel:BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int DepartmendId { get; set; }
        public Department Department { get; set; }
    }
}
