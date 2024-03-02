using Microsoft.AspNetCore.Mvc;
using WebApiWithController.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiWithController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private static List<TeacherModel> teachers = new List<TeacherModel>{ };

        // GET: api/<TeacherController>
        [HttpGet]
        public IEnumerable<TeacherModel> GetTeachers()
        {
            return teachers;
        }

        [HttpPost]
        public IActionResult PostTeachers(TeacherModel teacher)
        {
            teachers.Add(teacher);
            return Ok(teacher);
        }       
    }
}
