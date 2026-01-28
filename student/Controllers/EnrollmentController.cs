using Microsoft.AspNetCore.Mvc;
using student.Infrastructure.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace student.Controllers
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/enrollment")]
    public class EnrollmentController : ControllerBase {

        private readonly SchoolDbContext _db;

        public EnrollmentController(SchoolDbContext db)
        {
            _db = db;
        }

        


    }
}
