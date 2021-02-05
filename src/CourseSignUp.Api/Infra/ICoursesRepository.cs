using CourseSignUp.Api.Domain.Courses.Dtos;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Infra
{
    public interface ICoursesRepository
    {
        Task SignUp(string CourseId, StudentDto StudentDto);
    }
}
