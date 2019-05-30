using Domain.Core.Commands;
using Domain.Core.Events;
using Domain.Interfaces;
using Domain.Repositories;
using MediatR;
using System.Threading.Tasks;

namespace Domain.Handlers
{
    public class MediatorHandler : IMediatorHandler
    {
        private readonly IMediator _mediator;
        private readonly IUser _user;

        public MediatorHandler(IMediator mediator, IUser user)
        {
            _mediator = mediator;
            _user = user;
        }

        public Task EnviarComando<T>(T comando) where T : Command
        {
            return Publicar(comando);
        }

        public Task PublicarEvento<T>(T evento) where T : Event
        {
            if (!evento.MessageType.Equals("DomainNotification"))
                _user?.SalvarUser(evento);

            return Publicar(evento);
        }

        private Task Publicar<T>(T mensagem) where T : Message
        {
            return _mediator.Publish(mensagem);
        }
    }
}
