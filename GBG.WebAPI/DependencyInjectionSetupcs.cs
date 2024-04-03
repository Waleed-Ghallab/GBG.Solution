using GBG.Application.AppServices;
using GBG.Core.DomainModels;
using GBG.Core.Interfaces.AppService;
using GBG.Core.Interfaces.Common;
using GBG.Infrastructure.DBContext;
using GBG.Infrastructure.Repository;
using System.Diagnostics.Metrics;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace GBG.WebAPI
{
    public static class DependencyInjectionSetupcs
    {

        public static IServiceCollection RegisterAppServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            services.AddScoped<ICourseService, CourseService>();
            services.AddScoped<IStudentCourseService, StudentCourseService>();

            //inject any other service here
            return services;
        }
        public static IServiceCollection RegisterAppRepositories(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<Student, int>), typeof(Repository<Student, int, AppDBContext>));
            services.AddScoped(typeof(IRepository<Course, int>), typeof(Repository<Course, int, AppDBContext>));
            services.AddScoped(typeof(IRepository<StudentCourse, int>), typeof(Repository<StudentCourse, int, AppDBContext>));

            return services;
        }
    }
}
