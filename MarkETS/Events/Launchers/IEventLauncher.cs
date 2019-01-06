using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarkETS.Events.Launchers
{
    interface IEventLauncher
    {
        Task LaunchAsync(CancellationToken cancelToken);
    }
}
