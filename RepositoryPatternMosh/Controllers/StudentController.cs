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
    public class StudentController : ApiController
    {
        [HttpGet]
        [Route("api/Student/")]
        public IHttpActionResult GetAll()
        {
            var unitOfWork = new UnitOfWork(new AppDbContext());

            return Ok(unitOfWork.Students.GetAll());
        }

        [HttpGet]
        [Route("api/Student/{id}")]
        public IHttpActionResult Get(int id)
        {
            var unitOfWork = new UnitOfWork(new AppDbContext());

            return Ok(unitOfWork.Students.Get(id));
        }

        [HttpPost]
        [Route("api/Student")]
        public IHttpActionResult Add(Student student)
        {
            var unitOfWork = new UnitOfWork(new AppDbContext());
            unitOfWork.Students.Add(student);
            unitOfWork.Complete();
            return Ok();
        }


        [HttpPut]
        [Route("api/Student/{id}")]
        public IHttpActionResult Edit(int id, Student student)
        {
            if (id != student.Id)
            {
                return BadRequest("Student not found");
            }
            var unitOfWork = new UnitOfWork(new AppDbContext());
            unitOfWork.Students.UpdateStudent(student);
            unitOfWork.Complete();
            return Ok();
        }

    }
}