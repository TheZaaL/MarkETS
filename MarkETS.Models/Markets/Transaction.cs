using MarkETS.Models.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkETS.Models.Markets
{
    public class Transaction
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public float Price { get; set; }

        public int Quantity { get; set; }

        public virtual Company Company { get; set; }

        public virtual Portfolio Seller { get; set; }
        public virtual Portfolio Buyer { get; set; }
    }
}
