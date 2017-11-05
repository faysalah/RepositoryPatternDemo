using RepositoryPatternMosh.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPatternMosh.Core.Repositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        IEnumerable<Department> GetStudentsByDepartment(int id);
        void UpdateStudent(object obj);
    }
}