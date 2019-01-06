using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkETS.Models.Companies
{
    public class Dividend
    {
        public int Id { get; set; }

        public float NetIncome { get; set; }

        public float DividendPercentage { get; set; }
    }
}
