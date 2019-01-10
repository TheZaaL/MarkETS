using MarkETS.Models.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkETS.Models.Markets
{
    public class StockPriceEstimate
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public float Value { get; set; }

        public virtual Company Company { get; set; }
    }
}
