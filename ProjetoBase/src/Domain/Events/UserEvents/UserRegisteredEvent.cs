using Domain.Entities;
using System;
using Domain.Core.Events;

namespace Domain.Events.UserEvents
{
    public class UserRegisteredEvent : Event
    {
        public UserRegisteredEvent(User user)
        {
            Date = DateTime.Now;
            User = user;            
        }

        public User User { get; private set; }        
        public DateTime Date { get; set; }
    }
}
