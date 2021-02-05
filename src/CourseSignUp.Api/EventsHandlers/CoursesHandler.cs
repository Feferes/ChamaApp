using CourseSignUp.Api.Notifications;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CourseSignUp.Api.EventsHandlers
{
    public class CoursesHandler : INotificationHandler<CoursesActionsNotification>
    {
        public Task Handle(CoursesActionsNotification notification, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
            {
                Console.WriteLine($"Curso {notification.CourseId} foi {notification.Action} com sucesso.");
            });
        }
    }
}
