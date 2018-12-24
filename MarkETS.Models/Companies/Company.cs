using MarkETS.Models.Markets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkETS.Models.Companies
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }



        public virtual EconomicSector Sector { get; set; }
        public virtual ICollection<Stock> Stock { get; set; }
    }
}
