using System;

namespace CQRS.Events
{
    public interface IEvent
    {
        Guid Id { get; }
    }
}