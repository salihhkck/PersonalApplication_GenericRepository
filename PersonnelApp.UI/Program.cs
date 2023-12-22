using PersonalApp.Domains.Concrete;
using PersonnelApp.DAL;

namespace PersonnelApp.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new PersonnelContext());
            unitOfWork.DepartmentRepository.Add(new Department() {Name="Bilgi İşlem", IsActive=true, CreatedDate = DateTime.Now });
            unitOfWork.DepartmentRepository.Add(new Department() { Name = "Muhasebe", IsActive = true, CreatedDate = DateTime.Now });
            unitOfWork.DepartmentRepository.Add(new Department() { Name = "Yazılım", IsActive = true, CreatedDate = DateTime.Now });
            unitOfWork.DepartmentRepository.Add(new Department() { Name = "Test", IsActive = true, CreatedDate = DateTime.Now });
            unitOfWork.Complete();

        }
    }
}

