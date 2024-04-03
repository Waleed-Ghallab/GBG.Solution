using GBG.Core.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GBG.DTOs.AppDTOs;
using GBG.DTOs.Common;

namespace GBG.Core.Interfaces.AppService
{
    public interface IStudentService
    {

        Task<Result<StudentDTO>> GetByIdAsync(int id);
        Task<Result<StudentDTO>> CreateAsync(StudentDTO studentDTO);
        Task<Result<StudentDTO>> UpdateAsync(StudentDTO studentDTO);
        Task<Result<bool>> DeleteAsync(int id);
    }
}
