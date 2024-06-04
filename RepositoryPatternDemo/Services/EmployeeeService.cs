using RepositoryPatternDemo.Models;
using RepositoryPatternDemo.Repository;

namespace RepositoryPatternDemo.Services
{
    public class EmployeeeService:IEmployeeService
    {
        private readonly IEmployeeeRepository repo;
        public EmployeeeService(IEmployeeeRepository repo)
        {
            this.repo = repo;
        }

        public int AddEmployeee(Employeee employeee)
        {
            return repo.AddEmployeee(employeee);
        }

        public int DeleteEmployeee(int id)
        {
            return repo.DeleteEmployeee(id);
        }

        public Employeee GetEmployeeeById(int id)
        {
            return repo.GetEmployeeeById(id);
        }

        public IEnumerable<Employeee> GetEmployeees()
        {
            return repo.GetEmployeees();
        }

        public int UpdateEmployeee(Employeee employeee)
        {
            return repo.UpdateEmployeee(employeee);
        }
    }
}
