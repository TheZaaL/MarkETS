using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarkETS.Events.Launchers
{
    /// <summary>
    /// Norse god of mischiefs:
    /// Launches events that influences companies worth (contracts, hires/layoffs)
    /// </summary>
    internal class Loki : IEventLauncher
    {
        public void LaunchTask(CancellationToken cancelToken)
        {
            throw new NotImplementedException();
        }
    }
}
