using System;

namespace CourseSignUp.Api.Domain.Courses.Dtos
{
    public class SignUpToCourseDto
    {
        public string CourseId { get; set; }
        public StudentDto Student { get; set; }

        
    }
}