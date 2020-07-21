using System;
using System.Collections.Generic;
using System.Text;
using DL.Core.Domain.Commands;

namespace DL.Core.Domain.CommandBus
{
    /// <summary>
    /// 命令执行者
    /// </summary>
    public interface ICommandExecutor
    {

        T Execute<T>(Command<T> command);
    }
}
