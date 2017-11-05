using RepositoryPatternMosh.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace RepositoryPatternMosh.Persistance
{
    public class AppDbContext: DbContext
    {
        public AppDbContext()
            : base("name=DefaultContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Student> Students { get; set; }
    }
}