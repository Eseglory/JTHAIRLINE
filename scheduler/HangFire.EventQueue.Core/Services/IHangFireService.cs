using System;
using System.Collections.Generic;
using System.Text;

namespace HangFire.EventQueue.Core.Services
{
    public interface IHangFireService
    {
        void RunHangFireTask();
    }
}
