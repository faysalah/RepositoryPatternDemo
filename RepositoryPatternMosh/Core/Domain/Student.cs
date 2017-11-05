using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RepositoryPatternMosh.Core.Domain
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Department DepartmentId { get; set; }
    }
}