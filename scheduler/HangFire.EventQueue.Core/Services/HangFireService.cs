using System;
using System.Collections.Generic;
using System.Text;

namespace HangFire.EventQueue.Core.Services
{
    public class HangFireService : IHangFireService
    {
        public void RunHangFireTask()
        {
            Console.WriteLine("This is a task that has been run from HangFire Service.");
        }
    }
}
