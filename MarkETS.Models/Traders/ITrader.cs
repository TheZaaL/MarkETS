using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkETS.Models.Traders
{
    public interface ITrader
    {
        string GetName();
        Task Init();
        Task ProcessTurn();
    }
}
