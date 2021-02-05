using System.Threading.Tasks;
using CourseSignUp.Api.Domain.Courses.Command;
using CourseSignUp.Api.Domain.Courses.Dtos;
using CourseSignUp.Api.Infra;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignUp.Api.Controllers
{
    [ApiController, Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IStudentRepository _studentRepository;

        public StudentController(IMediator Mediator, IStudentRepository StudentRepository)
        {
            _mediator = Mediator;
            _studentRepository = StudentRepository;
        }

        [HttpPost, Route("create")]
        public async Task<IActionResult> Post([FromBody] StudentDto StudentDto)
        {
            var response = await _mediator.Send(new StudentCreateCommand
            {
                DateOfBirth = StudentDto.DateOfBirth,
                Name = StudentDto.Name,
                Email = StudentDto.Email
            });

            return Ok(response);
        }
    }
}
