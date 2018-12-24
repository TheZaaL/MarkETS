using MarkETS.Models.Companies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkETS.Models.Markets
{
    public class Stock
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public virtual Company Company { get; set; }
        public virtual Portfolio Portfolio { get; set; }
    }
}
