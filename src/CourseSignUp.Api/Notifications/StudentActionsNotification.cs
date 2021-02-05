using MediatR;

namespace CourseSignUp.Api.Notifications
{
    public class StudentActionsNotification : INotification
    {
        public string Name { get; set; }
        public ActionNotification Action { get; set; }
    }
}
