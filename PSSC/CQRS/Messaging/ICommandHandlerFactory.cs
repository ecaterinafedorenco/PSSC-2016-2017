using CQRS.CommandHandlers;
using CQRS.Commands;
using CQRS.EventHandler;
using CQRS.Events;
using System.Collections.Generic;

namespace CQRS.Messaging
{
    public interface ICommandHandlerFactory
    {
        ICommandHandler<T> GetHandler<T>() where T : Command;
    }
}