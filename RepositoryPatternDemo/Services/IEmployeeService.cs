using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employeee> GetEmployeees();
        Employeee GetEmployeeeById(int id);
        int AddEmployeee(Employeee employeee);
        int UpdateEmployeee(Employeee employeee);
        int DeleteEmployeee(int id);
    }
}
