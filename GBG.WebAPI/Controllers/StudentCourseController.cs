using GBG.Core.DomainModels;
using GBG.Core.Interfaces.AppService;
using GBG.DTOs.AppDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GBG.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class StudentCourseController : ControllerBase
    {
        private readonly IStudentCourseService _studentCourseService;

        public StudentCourseController(IStudentCourseService studentCourseService)
        {
            _studentCourseService=studentCourseService;
        }

        [HttpPost("RegisterStudentCourse")]
        public async Task<IActionResult> CreateStudentCourse( int studentID,int courseID)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _studentCourseService.StudentCourseRegister(studentID, courseID));
            }

            return BadRequest(ModelState);
        }
    }
}
