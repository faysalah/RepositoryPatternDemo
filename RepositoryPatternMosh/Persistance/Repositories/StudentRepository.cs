using RepositoryPatternMosh.Core.Domain;
using RepositoryPatternMosh.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPatternMosh.Persistance.Repositories
{
    public class StudentRepository: Repository<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext context) 
            : base(context)
        {
        }

        public IEnumerable<Department> GetStudentsByDepartment(int id)
        {
            return db.Departments.ToList();
        }

        public void UpdateStudent(object student)
        {
            db.Entry(student).State = System.Data.Entity.EntityState.Modified;
        }
        public AppDbContext db
        {
            get { return Context as AppDbContext; }
        }
    }
}