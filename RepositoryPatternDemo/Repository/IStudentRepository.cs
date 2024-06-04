using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Repository
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetStudent();
        Student GetStudentById(int id);
        int AddStudent(Student student);
        int UpdateStudent(Student student);
        int DeleteStudent(int id);
    }
}
