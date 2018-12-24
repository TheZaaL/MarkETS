using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkETS.Models.Markets
{
    public class Portfolio
    {
        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
