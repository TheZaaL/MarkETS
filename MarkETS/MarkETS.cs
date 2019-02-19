using MarkETS.AssemblyResolvers;
using MarkETS.Models.Traders;
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
        private TraderAssembilesResolver _traderResolver;

        [ImportMany(typeof(ITrader), RequiredCreationPolicy = CreationPolicy.Shared)]
        private IEnumerable<ITrader> _traders;

        public void Init()
        {
            _traderResolver = new TraderAssembilesResolver();

            _traderResolver.loadAssemblies(this);
        }
    }
}
