using CourseSignUp.Api.Notifications;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CourseSignUp.Api.EventsHandlers
{
    public class StudentHandler : INotificationHandler<StudentActionsNotification>
    {
        public Task Handle(StudentActionsNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"Aluno {notification.Name} foi {notification.Action} com sucesso.");
            });
        }
    }
}
