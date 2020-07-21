using System;
using System.Collections.Generic;
using System.Text;
using DL.Core.Domain.CommandBus;
using DL.Core.Domain.Commands;
using DL.Core.Domain.Commands.DomainCommands;

namespace DL.Core.Application
{
     public interface IStudentApplicationService
    {
        void SendSpenl();
    }
    public class StudentApplicationSerivce : IStudentApplicationService
    {
        public ICommandExecutor _executor;
        public StudentApplicationSerivce(ICommandExecutor executor)
        {
            _executor = executor;
        }
        public void SendSpenl()
        {
            Console.WriteLine("准备调用send");
            var request = new StudentResgistCommand("sdf");
            _executor.Execute(request);
        }
    }
    public class TestCommand
    {
        public string UserName { get; set; }
    }
}
