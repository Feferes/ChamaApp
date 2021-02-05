using CourseSignUp.Api.Domain.Courses.Command;
using CourseSignUp.Api.Infra;
using CourseSignUp.Api.Notifications;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Domain.Courses.Handler
{
    public class CoursesHandler : IRequestHandler<SignUpCreateCommand, string>
    {
        private readonly IMediator _mediator;
        private readonly ICoursesRepository _coursesRepository;

        public CoursesHandler(IMediator mediator, ICoursesRepository coursesRepository)
        {
            _mediator = mediator;
            _coursesRepository = coursesRepository;
        }

        public async Task<string> Handle(SignUpCreateCommand request, CancellationToken cancellationToken)
        {
            await _coursesRepository.SignUp(request.CourseId, request.Student);
            //TODO: Implementação do service worker pra gravar 
            await _mediator.Publish(new CoursesActionsNotification
            {
                CourseId = request.CourseId,
                Action = ActionNotification.Criado
            }, cancellationToken);

            return await Task.FromResult("Cadastro efetuado com sucesso");
        }
    }
}
