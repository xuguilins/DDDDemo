using System;
using System.Collections.Generic;
using System.Text;

namespace DL.Core.Infrastructure
{
    public class StudentService : IStudentService
    {
        public void Speak()
        {
            Console.WriteLine("我是基础设施层的持久化到数据库");
        }
    }
}
