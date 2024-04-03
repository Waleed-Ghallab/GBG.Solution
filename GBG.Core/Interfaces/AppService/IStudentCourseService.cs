using GBG.Core.DomainModels;
using GBG.DTOs.AppDTOs;
using GBG.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBG.Core.Interfaces.AppService
{
    public interface IStudentCourseService
    {

        Task<Result<StudentCourse>> StudentCourseRegister(int studentID,int courseID);
    }
}
