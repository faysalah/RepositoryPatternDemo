using RepositoryPatternMosh.Core.Domain;
using RepositoryPatternMosh.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RepositoryPatternMosh.Controllers
{
    public class DepartmentController : ApiController
    {
        
        [HttpGet]
        [Route("api/Department/")]
        public IHttpActionResult GetAll()
        {
            var unitOfWork = new UnitOfWork(new AppDbContext());
            return Ok(unitOfWork.Departments.GetAll());
        }

        [HttpGet]
        [Route("api/Department/{id}")]
        public IHttpActionResult Get(int id)
        {
            var unitOfWork = new UnitOfWork(new AppDbContext());

            return Ok(unitOfWork.Departments.Get(id));
        }

        [HttpPost]
        [Route("api/Department")]
        public IHttpActionResult Add(Department depatment)
        {
            var unitOfWork = new UnitOfWork(new AppDbContext());
            unitOfWork.Departments.Add(depatment);
            unitOfWork.Complete();
            return Ok();
        }

        [HttpPut]
        [Route("api/Department/{id}")]
        public IHttpActionResult Edit(int id, Department department)
        {
            if(id != department.Id)
            {
                return BadRequest("Department not Found");
            }
            var unitOfWork = new UnitOfWork(new AppDbContext());
            unitOfWork.Departments.UpdateDepartment(department);
            unitOfWork.Complete();
            return Ok();
        }
    }
}
