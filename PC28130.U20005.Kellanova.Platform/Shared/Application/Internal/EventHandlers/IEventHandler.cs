using PC28130.U20005.Kellanova.Platform.Shared.Domain.Model.Events;
using Cortex.Mediator.Notifications;

namespace PC28130.U20005.Kellanova.Platform.Shared.Application.Internal.EventHandlers;

public interface IEventHandler<in TEvent> : INotificationHandler<TEvent> where TEvent : IEvent
{
}