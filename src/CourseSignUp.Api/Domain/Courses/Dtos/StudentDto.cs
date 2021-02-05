using System;

namespace CourseSignUp.Api.Domain.Courses.Dtos
{
    public class StudentDto
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
