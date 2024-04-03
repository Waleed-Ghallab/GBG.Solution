using GBG.Core.DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBG.Infrastructure.DBContext
{
    public static class Initializer
    {
        //Extension Method for modelBuilder to initialize entities
        public static void SeedDB(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    Name = "Waleed",
                    Gender = "Male"

                });
            modelBuilder.Entity<Course>().HasData(
                new Course {
                    Id = 1,
                    Name="Computer Science",
                    Description="CS101 : A brief intoduction to scientific computing"

                });
        }
    }
}
