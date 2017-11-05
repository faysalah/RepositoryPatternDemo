using RepositoryPatternMosh.Core.Domain;
using RepositoryPatternMosh.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RepositoryPatternMosh.Persistance.Repositories
{
    public class DepartmentRepository : Repository<Department>,IDepartmentRepository
    {
        public DepartmentRepository(AppDbContext context) 
            : base(context)
        {
        }
        
        public Department GetDepartmentWithStudent(int id)
        {
            return db.Departments.Find(id);
        }

        public void UpdateDepartment(object department)
        {
            db.Entry(department).State = EntityState.Modified;
        }

        public AppDbContext db
        {
            get { return Context as AppDbContext; }
        }
    }
}