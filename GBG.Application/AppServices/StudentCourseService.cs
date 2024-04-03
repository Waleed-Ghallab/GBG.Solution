using AutoMapper;
using GBG.Core.DomainModels;
using GBG.Core.Interfaces.AppService;
using GBG.Core.Interfaces.Common;
using GBG.DTOs.AppDTOs;
using GBG.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBG.Application.AppServices
{
    public class StudentCourseService : IStudentCourseService
    {

        private readonly IRepository<StudentCourse, int> _studentCourseRepository;
        private readonly IMapper _mapper;

        public StudentCourseService(IRepository<StudentCourse, int> studentCourseRepository, IMapper mapper)
        {
            _studentCourseRepository = studentCourseRepository;
            _mapper = mapper;
        }

        public async Task<Result<StudentCourse>> StudentCourseRegister(int studentID, int courseID)
        {
            try
            {
                StudentCourse studentCourse = new StudentCourse() { StudentId = studentID, CourseId = courseID };

                await _studentCourseRepository.CreateAsync(studentCourse);
                await _studentCourseRepository.SaveChangesAsync();
                return new Result<StudentCourse>
                {
                    StatusCode = 200,
                    Data = studentCourse,
                    Message = "Success",
                    Status = true
                };
            }catch (Exception)
            {
                return new Result<StudentCourse>
                {
                    StatusCode = 500,
                    Message = "Internal Server Error",
                    Status = false
                };
            }
        }
    }
}
