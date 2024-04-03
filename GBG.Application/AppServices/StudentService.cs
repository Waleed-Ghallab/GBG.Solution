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
using GBG.Infrastructure.Repository;

namespace GBG.Application.AppServices
{
    public class StudentService : IStudentService
    {
        private readonly IRepository<Student,int> _studentRepository;
        private readonly IMapper _mapper;   

        public StudentService(IRepository<Student, int> studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public async Task<Result<StudentDTO>> CreateAsync(StudentDTO studentDTO)
        {
            try
            {
                Student student = _mapper.Map<Student>(studentDTO);
                await _studentRepository.CreateAsync(student);
                await _studentRepository.SaveChangesAsync();
                return new Result<StudentDTO>
                {
                    StatusCode = 200,
                    Data = studentDTO,
                    Message = "Success",
                    Status = true
                };
            }
            catch (Exception)
            {
                return new Result<StudentDTO>
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

        public Task<Result<StudentDTO>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result<StudentDTO>> UpdateAsync(StudentDTO studentDTO)
        {
            throw new NotImplementedException();
        }
    }
}
