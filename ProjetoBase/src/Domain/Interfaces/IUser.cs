using Domain.Core.Events;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repositories
{
    public interface IUser
    {
        void SalvarUser<T>(T evento) where T : Event;
        void Update(User user);
        User GetUserByUsername(string username);
        User GetByAuthorizationCode(string authorizationCode);
        Guid GetUserId();
        bool IsAuthenticated();
    }
}
