using MediatR;

namespace CourseSignUp.Api.Domain.Courses.Command
{
    public class CoursesCreateCommand : IRequest<string>
    {
        public string Id { get; set; }
        public int Capacity { get; set; }
        public int NumberOfStudents { get; set; }
    }
}
