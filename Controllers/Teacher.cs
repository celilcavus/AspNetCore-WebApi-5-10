using Microsoft.AspNetCore.Mvc;
using CelilCavus.StudentCourseApi.Data.Entites;
using CelilCavus.UnitOfWork;

namespace CelilCavus.TeacherApi.Data.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeacherController : ControllerBase
    {
        private readonly IUnitOfWork _repository;

        public TeacherController(IUnitOfWork repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult GetTeacher()
        {
            return Ok(_repository.GetRepository<Teacher>().GetList());
        }
        [HttpGet("{id}")]
        public IActionResult GetTeacher(int id)
        {
            if (id is not < 0)
            {
                return Ok(_repository.GetRepository<Teacher>().GetList());
            }
            else return StatusCode(404);

        }
        [HttpPost]
        public IActionResult PostTeacher(Teacher values)
        {
            if (values is not null)
            {
                if (!string.IsNullOrEmpty(values.ToString()))
                {
                    _repository.GetRepository<Teacher>().Add(values);
                    _repository.SaveChanges();
                    return StatusCode(200);
                }
                else return StatusCode(404);
            }
            else return StatusCode(404);
        }

        [HttpPut]
        public IActionResult PutTeacher(Teacher values)
        {
            if (values is not null)
            {
                if (!string.IsNullOrEmpty(values.ToString()))
                {
                    _repository.GetRepository<Teacher>().Update(values);
                    _repository.SaveChanges();
                    return StatusCode(200);
                }
                else return StatusCode(404);
            }
            else return StatusCode(404);
        }

        [HttpDelete]
        public IActionResult DeleteTeacher(Teacher values)
        {
            if (values is not null)
            {
                if (!string.IsNullOrEmpty(values.ToString()))
                {
                    _repository.GetRepository<Teacher>().Delete(values);
                    _repository.SaveChanges();
                    return StatusCode(200);
                }
                else return StatusCode(404);
            }
            else return StatusCode(404);
        }
    }
}