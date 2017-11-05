using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RepositoryPatternMosh.Core.Repositories;
using RepositoryPatternMosh.Persistance.Repositories;

namespace RepositoryPatternMosh.Persistance
{
    public class UnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            Departments = new DepartmentRepository(_context);
            Students = new StudentRepository(_context);
        }

        public IDepartmentRepository Departments { get; private set; }
        public IStudentRepository Students { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}