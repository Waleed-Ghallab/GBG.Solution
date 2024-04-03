using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GBG.Core.DomainModels;
using GBG.Core.Interfaces.AppService;
using GBG.Core.Interfaces.Common;
using GBG.DTOs.AppDTOs;
using GBG.DTOs.Common;

namespace GBG.Application.AppServices
{
    public class CourseService : ICourseService
    {
        private readonly IRepository<Course, int> _courseRepository;
        private readonly IMapper _mapper;

        public CourseService(IRepository<Course, int> courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }

        public async Task<Result<CourseDTO>> CreateAsync(CourseDTO courseDTO)
        {
            try
            {
                Course course = _mapper.Map<Course>(courseDTO);
                await _courseRepository.CreateAsync(course);
                await _courseRepository.SaveChangesAsync();
                return new Result<CourseDTO>
                {
                    StatusCode = 200,
                    Data = courseDTO,
                    Message = "Success",
                    Status = true
                };
            }
            catch (Exception)
            {
                return new Result<CourseDTO>
                {
                    StatusCode = 500,
                    Message = "Internal Server Error",
                    Status = false
                };
            }
        }

        public Task<Result<bool>> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<CourseDTO>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<CourseDTO>> UpdateAsync(CourseDTO courseDTO)
        {
            throw new NotImplementedException();
        }

    }
}
