using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DL.Core.Domain.Commands.DomainCommands
{
    public class StudentResgistCommand : Command<string>
    {
        public string UserName { get; set; }

        public StudentResgistCommand(string name)
        {
            UserName = name;
        }

        public override void Validate()
        {
            Console.WriteLine("验证数据");
        }
    }
}
