using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkETS.Models.Markets
{
    public class Portfolio
    {
        public int Id { get; set; }

        /// <summary>
        /// Protects the portfolio from undesirable changes
        /// </summary>
        public string HashedPassword { get; set; }

        public virtual ICollection<Stock> Stocks { get; set; }
    }
}
