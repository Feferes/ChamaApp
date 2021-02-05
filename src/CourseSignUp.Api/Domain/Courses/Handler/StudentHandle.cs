using CourseSignUp.Api.Domain.Courses.Command;
using CourseSignUp.Api.Infra;
using CourseSignUp.Api.Notifications;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Domain.Courses.Handler
{
    public class StudentHandle : IRequestHandler<StudentCreateCommand, string>
    {
        private readonly IMediator _mediator;
        private readonly IStudentRepository _studentRepository;

        public StudentHandle(IMediator mediator, IStudentRepository StudentRepository)
        {
            _mediator = mediator;
            _studentRepository = StudentRepository;
        }

        public async Task<string> Handle(StudentCreateCommand request, CancellationToken cancellationToken)
        {
            await _studentRepository.Create(new Dtos.StudentDto
            {
                DateOfBirth = request.DateOfBirth,
                Email = request.Email,
                Name = request.Name
            });

            await _mediator.Publish(new StudentActionsNotification
            {
                Name = request.Name,
                Action = ActionNotification.Criado
            }, cancellationToken);

            return await Task.FromResult("Cadastro efetuado com sucesso");
        }
    }
}
