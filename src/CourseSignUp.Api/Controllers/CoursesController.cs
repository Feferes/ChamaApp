using CourseSignUp.Api.Domain.Courses.Command;
using CourseSignUp.Api.Domain.Courses.Dtos;
using CourseSignUp.Api.Infra;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Courses
{
    [ApiController, Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ICoursesRepository _coursesRepository;

        public CoursesController(IMediator Mediator, ICoursesRepository CoursesRepository)
        {
            _mediator = Mediator;
            _coursesRepository = CoursesRepository;
        }

        [HttpGet, Route("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            // TODO
            return Ok(new CourseDto
            {

            });
        }

        [HttpPost, Route("create")]
        public Task<IActionResult> Post([FromBody] CreateCourseDto createCourseDto)
        {
            throw new NotImplementedException();
        }

        [HttpPost, Route("sign-up")]
        public async Task<IActionResult> Post([FromBody] SignUpToCourseDto signUpToCourseDto)
        {
            var response = await _mediator.Send(new SignUpCreateCommand
            {
                CourseId = signUpToCourseDto.CourseId,
                Student = signUpToCourseDto.Student
            });

            return Ok(response);

        }
    }
}
