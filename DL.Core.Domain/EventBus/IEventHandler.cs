using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DL.Core.Domain.EventBus
{
    public interface IEventHandler
    {
        void Puslish<T>(T notify) where T : EventNotify;
    }

    public class EventHandler : IEventHandler
    {
        private readonly IMediator _mediator;

        public EventHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public void Puslish<T>(T notify) where T : EventNotify
        {
            _mediator.Publish(notify);
        }
    }
}