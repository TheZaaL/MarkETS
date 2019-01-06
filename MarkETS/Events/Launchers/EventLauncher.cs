using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarkETS.Events.Launchers
{
    abstract class EventLauncher : IEventLauncher
    {
        private Task _task;
        protected CancellationToken CancelToken { get; private set; }

        public void LaunchTask(CancellationToken cancelToken)
        {
            if (_task?.Status != TaskStatus.Canceled ||
                _task?.Status != TaskStatus.Faulted ||
                _task?.Status != TaskStatus.RanToCompletion)
            {
                throw new InvalidOperationException("The task is already running");
            }

            CancelToken = cancelToken;
            _task = Task.Factory.StartNew(DoWork, CancelToken);
        }

        abstract protected void DoWork();
    }
}
