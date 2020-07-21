using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DL.Core.Domain.Commands
{
    
    public abstract class Command<T>:ICommand<T>
    {
        public abstract void Validate();
    }
    
}
