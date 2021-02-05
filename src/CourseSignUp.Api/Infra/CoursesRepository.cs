using CourseSignUp.Api.Domain.Courses.Dtos;
using CourseSignUp.Api.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Infra
{
    public class CoursesRepository : ICoursesRepository
    {
        public List<CourseDto> Courses { get; }

        public CoursesRepository()
        {
            Courses = new List<CourseDto>();
        }

        public async Task SignUp(string CourseId, StudentDto StudentDto)
        {
            await Task.Run(() => Courses.Add(new CourseDto { Id = CourseId }));
        }
    }
}
