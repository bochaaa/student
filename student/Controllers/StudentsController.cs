using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using student.Domain.Entities;

namespace student.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private static readonly List<Student> Students = new List<Student>
        {
            new Student { Id = 1, FirstName = "Santi", LastName ="Prueba",Address=" 123 a ", DNI=33333333 },
            
            new Student { Id = 2, FirstName = "Santi2", LastName ="Prueba2",Address=" 123 a ", DNI=33333333 },

        };
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudents() {
            return Ok(Students);
        }


    }
 

}
