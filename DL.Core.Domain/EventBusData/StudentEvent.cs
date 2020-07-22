using DL.Core.Domain.EventBus;
using System;
using System.Collections.Generic;
using System.Text;

namespace DL.Core.Domain.EventBusData
{
    public class StudentEvent : EventNotify
    {
        public string UserName { get; set; }
    }
}