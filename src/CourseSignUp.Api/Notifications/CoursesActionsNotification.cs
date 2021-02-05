using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Notifications
{
    public class CoursesActionsNotification : INotification
    {
        public string CourseId { get; set; }
        public ActionNotification Action { get; set; }
    }
}
