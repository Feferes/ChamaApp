using CourseSignUp.Api.Domain.Courses.Dtos;
using MediatR;

namespace CourseSignUp.Api.Domain.Courses.Command
{
    public class SignUpCreateCommand : IRequest<string>
    {
        public string CourseId { get; set; }
        public StudentDto Student { get; set; }
    }
}
