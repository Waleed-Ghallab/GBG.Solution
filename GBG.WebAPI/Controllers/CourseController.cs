using GBG.Core.Interfaces.AppService;
using GBG.DTOs.AppDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace GBG.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService) {
            _courseService = courseService;
        }

        [HttpPost("CreateCourse")]
        public async Task<IActionResult> CreateCourse([FromBody] CourseDTO courseDTO)
        {
            if (ModelState.IsValid)
            {
                return Ok(await _courseService.CreateAsync(courseDTO));
            }

            return BadRequest(ModelState);
        }
    }
}
