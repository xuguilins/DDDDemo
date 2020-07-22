using DL.Core.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using DL.Core.Domain.Commands.DomainCommands;

namespace DL.Core.Domain.CommandBus
{
    public class CommandExecutor : ICommandExecutor
    {
        private readonly IMediator _mediator;

        public CommandExecutor(IMediator mediator)
        {
            _mediator = mediator;
        }

        public T Execute<T>(Command<T> command)
        {
            command.Validate();
            var result = _mediator.Send(command).Result;
            return result;
        }
    }
}