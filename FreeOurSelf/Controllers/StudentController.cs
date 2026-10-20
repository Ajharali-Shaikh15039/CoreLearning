using FreeOurSelf.Models;
using FreeOurSelf.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Globalization;


namespace FreeOurSelf.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        IStudent _studentService;

        public StudentController(IStudent _studentService)
        {
            this._studentService = _studentService;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> LoginDetail(LoginRequestModel request) {
            var response = await _studentService.LoginDetail(request);
            if (response == null) {
                return NotFound();
                    }
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _studentService.GetAll();
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await _studentService.Get(id);
            if (response == null) return NotFound();
            return Ok(response);
        }

        // POST: api/student
        [HttpPost]
        public async Task<IActionResult> Create(StudentModel student)
        {
            var response = await _studentService.Create(student);
            return Ok(response);
        }

        // PUT: api/student/1
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, StudentModel student)
        {
            if(id != student.Id)
            {
                return BadRequest();
            }
            await _studentService.Update(id, student);
            return NoContent();

        }

        // DELETE: api/student/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _studentService.Delete(id);
            return NoContent();
        }
    }
}
