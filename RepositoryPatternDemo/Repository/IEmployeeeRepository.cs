using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Repository
{
    public interface IEmployeeeRepository
    {
        IEnumerable<Employeee> GetEmployeees();
        Employeee GetEmployeeeById(int id);
        int AddEmployeee(Employeee employeee);
        int UpdateEmployeee(Employeee employeee);
        int DeleteEmployeee(int id);
    }
}
