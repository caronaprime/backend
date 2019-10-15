using Business.Notifications;
using System.Collections.ObjectModel;

namespace Business.Interfaces
{
    public interface INotifier
    {
        bool HasNotification();

        ReadOnlyCollection<Notification> GetNotifications();

        void Handle(Notification notification);
    }
}