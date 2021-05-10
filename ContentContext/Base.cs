using System;
using Portal.NotificationContext;
namespace Portal.ContentContext
{
    public abstract class Base : Notifiable 
    {
        public Base()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}