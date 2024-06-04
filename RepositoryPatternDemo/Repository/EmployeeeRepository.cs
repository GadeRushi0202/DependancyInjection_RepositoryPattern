using RepositoryPatternDemo.Data;
using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Repository
{
    public class EmployeeeRepository:IEmployeeeRepository
    {
        ApplicationDbContext db;
        public EmployeeeRepository(ApplicationDbContext db) // DI pattern inject dependency in constructor.
        {
            this.db = db;
        }

        public int AddEmployeee(Employeee employeee)
        {
            db.employeees.Add(employeee);
            // SaveChages() reflect the changes from Dbset to DB
            int result = db.SaveChanges();
            return result;
        }

        public int DeleteEmployeee(int id)
        {
            int res = 0;
            var result = db.employeees.Where(x => x.Id == id).FirstOrDefault();
            if (result != null)
            {
                db.employeees.Remove(result);
                res = db.SaveChanges();
            }
            return res;
        }

        public Employeee GetEmployeeeById(int id)
        {
            var result = db.employeees.Where(x => x.Id == id).SingleOrDefault();
            return result;

        }

        public IEnumerable<Employeee> GetEmployeees()
        {
            return db.employeees.ToList();
        }

        public int UpdateEmployeee(Employeee employeee)
        {
            int res = 0;


            var result = db.employeees.Where(x => x.Id == employeee.Id).FirstOrDefault();

            if (result != null)
            {
                result.Name = employeee.Name; // book contains new data, result contains old data
                result.Email = employeee.Email;
                result.Age = employeee.Age;
                result.Salary = employeee.Salary;

                res = db.SaveChanges();// update those changes in DB
            }

            return res;
        }
    }
}
