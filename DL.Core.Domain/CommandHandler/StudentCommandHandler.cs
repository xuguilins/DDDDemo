using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using DL.Core.Domain.Commands;
using DL.Core.Domain.Commands.DomainCommands;
using System.Threading.Tasks;
using System.Threading;

namespace DL.Core.Domain.CommandHandler
{
    public class StudentCommandHandler : IRequestHandler<StudentResgistCommand, string>
    {
        public Task<string> Handle(StudentResgistCommand request, CancellationToken cancellationToken)
        {
            Console.WriteLine("我在处理handler");
            return Task.FromResult("sdf");
   
        }
    }
}
