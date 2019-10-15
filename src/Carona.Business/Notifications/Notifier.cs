using Business.Interfaces;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Business.Notifications
{
    public class Notifier : INotifier
    {
        private readonly List<Notification> _notifications;

        public Notifier() => _notifications = new List<Notification>();

        public ReadOnlyCollection<Notification> GetNotifications() => _notifications.AsReadOnly();

        public void Handle(Notification notification) => _notifications.Add(notification);

        public bool HasNotification() => _notifications.Any();
    }
}