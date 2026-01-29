using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using student.Domain.Entities;
using student.Infrastructure.Data;

namespace student.Controllers;

    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly SchoolDbContext _db;

        public StudentsController(SchoolDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents()
        {
            return await _db.Students.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudentById(int id)
        {
            var student = await _db.Students.FindAsync(id);

            if (student == null)
                return NotFound();

            return student;
        }

        [HttpPost]
        public async Task<ActionResult<Student>> CreateStudent(Student student)
        {
            _db.Students.Add(student);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetStudentById), new { id = student.Id }, student);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Student>> PutStudent(int id, Student student)
        {
            if (id != student.Id)
                return BadRequest("ID does not match ");

            var exist = await _db.Students.AnyAsync(student => student.Id == id);

            if (!exist)
                return NotFound();

            _db.Entry(student).State = EntityState.Modified;

            await _db.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Student>> DeleteStudent(int id)
        {
            var student = await _db.Students.FindAsync(id);

            if (student == null)
                return NotFound("Student does not exist");

            _db.Students.Remove(student);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }

