using MarkETS.Traders;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkETS
{
    public class MarkETS
    {
        [ImportMany(typeof(ITrader))]
        private IEnumerable<ITrader> traders;
    }
}
