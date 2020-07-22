using System;
using System.Collections.Generic;
using System.Text;
using DL.Core.Domain.CommandBus;
using DL.Core.Domain.Commands;
using DL.Core.Domain.Commands.DomainCommands;
using DL.Core.Domain.EventBus;
using DL.Core.Domain.EventBusData;

namespace DL.Core.Application
{
    public interface IStudentApplicationService
    {
        void SendSpenl();
    }

    public class StudentApplicationSerivce : IStudentApplicationService
    {
        public ICommandExecutor _executor;
        private IEventHandler _bus;

        public StudentApplicationSerivce(ICommandExecutor executor, IEventHandler handler)
        {
            _executor = executor;
            _bus = handler;
        }

        public void SendSpenl()
        {
            Console.WriteLine("准备调用send");
            var request = new StudentResgistCommand("sdf");
            _executor.Execute(request);
            var eventinfo = new StudentEvent();
            //调用事件
            _bus.Puslish(eventinfo);
        }
    }

    public class TestCommand
    {
        public string UserName { get; set; }
    }
}