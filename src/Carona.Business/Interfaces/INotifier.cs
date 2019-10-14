using Carona.Business.Notifications;
using System.Collections.ObjectModel;

namespace Carona.Business.Interfaces
{
    public interface INotifier
    {
        bool HasNotification();

        ReadOnlyCollection<Notification> GetNotifications();

        void Handle(Notification notification);
    }
}