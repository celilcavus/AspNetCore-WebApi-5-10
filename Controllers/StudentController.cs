using CelilCavus.StudentCourseApi.Data.Entites;
using CelilCavus.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace CelilCavus.StudentStudentApi.Data.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IUnitOfWork _repository;

        public StudentController(IUnitOfWork repository)
        {
            _repository = repository;
        }


        [HttpGet]
        public IActionResult GetStudent()
        {
            return Ok(_repository.GetRepository<StudentCourse>().GetList());
        }
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            if (id is not < 0)
            {
                return Ok(_repository.GetRepository<StudentCourse>().GetList());
            }
            else return StatusCode(404);

        }
        [HttpPost]
        public IActionResult PostStudent(StudentCourse values)
        {
            if (values is not null)
            {
                if (!string.IsNullOrEmpty(values.ToString()))
                {
                    _repository.GetRepository<StudentCourse>().Add(values);
                    _repository.SaveChanges();
                    return StatusCode(200);
                }
                else return StatusCode(404);
            }
            else return StatusCode(404);
        }

        [HttpPut]
        public IActionResult PutStudent(StudentCourse values)
        {
            if (values is not null)
            {
                if (!string.IsNullOrEmpty(values.ToString()))
                {
                    _repository.GetRepository<StudentCourse>().Update(values);
                    _repository.SaveChanges();
                    return StatusCode(200);
                }
                else return StatusCode(404);
            }
            else return StatusCode(404);
        }

        [HttpDelete]
        public IActionResult DeleteStudent(StudentCourse values)
        {
            if (values is not null)
            {
                if (!string.IsNullOrEmpty(values.ToString()))
                {
                   _repository.GetRepository<StudentCourse>().Delete(values);
                   _repository.SaveChanges();
                    return StatusCode(200);
                }
                else return StatusCode(404);
            }
            else return StatusCode(404);
        }
    }
}