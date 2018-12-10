using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkETS.Traders
{
    public interface ITrader
    {
        Task ProcessTurn();
        Task Init();
    }
}
