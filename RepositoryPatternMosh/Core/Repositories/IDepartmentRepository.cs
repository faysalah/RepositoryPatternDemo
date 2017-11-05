using RepositoryPatternMosh.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPatternMosh.Core.Repositories
{
    public interface IDepartmentRepository: IRepository<Department>
    {
        Department GetDepartmentWithStudent(int id);
        void UpdateDepartment(object department);
    }
}