using CourseSignUp.Api.Domain.Courses.Dtos;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Infra
{
    public interface IStudentRepository
    {
        Task Create(StudentDto studentDto);
    }
}
