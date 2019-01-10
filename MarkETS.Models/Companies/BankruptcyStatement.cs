using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkETS.Models.Companies
{
    public class BankruptcyStatement
    {
        public int Id { get; set; }

        public float LiquidatedAssetWorth { get; set; }

        public virtual Company Company { get; set; }
    }
}
