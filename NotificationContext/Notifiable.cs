using System.Collections.Generic;

namespace Portal.NotificationContext
{

    public abstract class Notifiable
    {
        public List<Notification> Notifications { get; set; }

        public void add(Notification notification)
        {
            Notifications.Add(notification);
        }

         public void addRange(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }

    }
}