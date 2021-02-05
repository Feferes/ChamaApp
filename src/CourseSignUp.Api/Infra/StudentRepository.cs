using CourseSignUp.Api.Domain.Courses.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Infra
{
    public class StudentRepository : IStudentRepository
    {
        public List<StudentDto> Students { get; }

        public StudentRepository()
        {
            Students = new List<StudentDto>();
        }

        public async Task Create(StudentDto studentDto)
        {
            await Task.Run(() => Students.Add(studentDto));
        }
    }
}
