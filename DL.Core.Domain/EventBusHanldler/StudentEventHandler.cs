using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DL.Core.Domain.EventBusData;
using MediatR;

namespace DL.Core.Domain.EventBusHanldler
{
    public class StudentEventHandler : INotificationHandler<StudentEvent>
    {
        public Task Handle(StudentEvent notification, CancellationToken cancellationToken)
        {
            Console.WriteLine("我在处理事件");
            return Task.CompletedTask;
        }
    }
}