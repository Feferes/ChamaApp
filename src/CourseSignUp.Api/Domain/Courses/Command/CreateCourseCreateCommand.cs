using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Domain.Courses.Command
{
    public class CreateCourseCreateCommand : IRequest<string>
    {
        public string LecturerId { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
    }
}
