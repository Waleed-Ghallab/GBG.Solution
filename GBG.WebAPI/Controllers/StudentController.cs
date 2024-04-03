using GBG.Application.AppServices;
using GBG.Core.Interfaces.AppService;
using GBG.DTOs.AppDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GBG.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService) { 
            _studentService = studentService;
        }

        [HttpPost("CreateStudent")]
        public async Task<IActionResult> CreateStudent([FromBody] StudentDTO studentDTO)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _studentService.CreateAsync(studentDTO));
            }

            return BadRequest(ModelState);
        }
    }
}
