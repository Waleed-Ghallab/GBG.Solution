using GBG.Core.DomainModels.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBG.Core.DomainModels
{
    public class Student : Entity<int>
    {
        
        public string? Name { get; set; }
        public string? Gender { get; set; }
        public ICollection<StudentCourse>? StudentCourses { get; set; }

    }
}
