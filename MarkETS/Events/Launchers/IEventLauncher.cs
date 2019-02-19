using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkETS.Events.Launchers
{
    [InheritedExport]
    public interface IEventLauncher
    {
        string GetName();
    }
}
