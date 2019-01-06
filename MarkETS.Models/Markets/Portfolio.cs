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

        public float DisponibleCash { get; set; }
        // TODO Implement dividends

        public virtual ICollection<Stock> Stocks { get; set; }

        public virtual ICollection<SellingOffer> SellingOffers { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
