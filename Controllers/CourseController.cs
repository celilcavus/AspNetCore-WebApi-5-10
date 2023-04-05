using CelilCavus.StudentCourseApi.Data.Entites;
using CelilCavus.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace CelilCavus.StudentCourseApi.Data.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly IUnitOfWork _repository;

        public CourseController(IUnitOfWork repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetCourse()
        {
            return Ok(_repository.GetRepository<Course>().GetList());
        }
        [HttpGet("{id}")]
        public IActionResult GetCourse(int id)
        {
            if (id is not < 0)
            {
                return Ok(_repository.GetRepository<Course>().GetById(id));
            }
            else return StatusCode(404);

        }
        [HttpPost]
        public IActionResult PostCourse(Course values)
        {
            if (values is not null)
            {
                if (!string.IsNullOrEmpty(values.ToString()))
                {
                    _repository.GetRepository<Course>().Add(values);
                    _repository.SaveChanges();
                    return StatusCode(200);
                }
                else return StatusCode(404);
            }
            else return StatusCode(404);
        }

        [HttpPut]
        public IActionResult PutCourse(Course values)
        {
            if (values is not null)
            {
                if (!string.IsNullOrEmpty(values.ToString()))
                {
                    _repository.GetRepository<Course>().Update(values);
                    _repository.SaveChanges();
                    return StatusCode(200);
                }
                else return StatusCode(404);
            }
            else return StatusCode(404);
        }

        [HttpDelete]
        public IActionResult DeleteCourse(Course values)
        {
            if (values is not null)
            {
                if (!string.IsNullOrEmpty(values.ToString()))
                {
                    _repository.GetRepository<Course>().Delete(values);
                    _repository.SaveChanges();
                    return StatusCode(200);
                }
                else return StatusCode(404);
            }
            else return StatusCode(404);
        }
    }
}