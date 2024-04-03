using GBG.DTOs.AppDTOs;
using GBG.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBG.Core.Interfaces.AppService
{
    public interface ICourseService
    {

        Task<Result<CourseDTO>> GetByIdAsync(int id);
        Task<Result<CourseDTO>> CreateAsync(CourseDTO courseDTO);
        Task<Result<CourseDTO>> UpdateAsync(CourseDTO courseDTO);
        Task<Result<bool>> DeleteAsync(int id);
    }
}
