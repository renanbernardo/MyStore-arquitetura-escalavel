using DomainNotificationHelper;
using DomainNotificationHelper.Events;
using System.Net;
using System.Net.Http;

namespace MyStore.Api.Controllers
{
    public class BaseController
    {
        public IHandler<DomainNotification> Notifications;
        public HttpResponseMessage ResponseMessage;

        public BaseController()
        {
            Notifications = DomainEvent.Container.GetService<IHandler<DomainNotification>>();
            ResponseMessage = new HttpResponseMessage();
        }

        public HttpResponseMessage CreateResponse(HttpStatusCode code, object result)
        {
            if (Notifications.HasNotifications())
                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            else
                return new HttpResponseMessage(code);
        }
    }
}
