﻿using System.Threading.Tasks;
using ReusableServices.Common.Messages;

namespace ReusableServices.Common.RabbitMq
{
  public interface IBusPublisher
  {
    Task SendAsync<TCommand>(TCommand command, ICorrelationContext context) where TCommand : ICommand;

    Task PublishAsync<TEvent>(TEvent @event, ICorrelationContext context) where TEvent : IEvent;
  }
}