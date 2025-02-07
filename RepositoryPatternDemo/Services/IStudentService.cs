﻿using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetStudent();
        Student GetStudentById(int id);
        int AddStudent(Student student);
        int UpdateStudent(Student student);
        int DeleteStudent(int id);
    }
}
