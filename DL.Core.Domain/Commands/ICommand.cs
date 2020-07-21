using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace DL.Core.Domain.Commands
{
    public interface ICommand<T>:IRequest<T> 
    { 

    }
}
