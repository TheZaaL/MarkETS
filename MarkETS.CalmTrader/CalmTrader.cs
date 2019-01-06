using MarkETS.Models.Traders;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarkETS.CalmTrader
{
    [Export(typeof(ITrader))]
    public class CalmTrader : ITrader
    {
        public string GetName()
        {
            throw new NotImplementedException();
        }

        public Task Init()
        {
            throw new NotImplementedException();
        }

        public Task ProcessTurn()
        {
            throw new NotImplementedException();
        }
    }
}
