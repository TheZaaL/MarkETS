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

        /// <summary>
        /// Set to false when a bankruptcy happened
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Determines and influences price of stocks
        /// </summary>
        public float EstimatedValue { get; set; }
        // TODO Make council take in account when deciding price point of stock

        /// <summary>
        /// Total stock count currently on the market. Influences price of stocks
        /// </summary>
        public int StockCount { get; set; }
        // TODO Make council use stock count
        // TODO Enforce maximum stock count 

        /// <summary>
        /// Employee count, the more there is the higher the chances
        /// to get an economical event.
        /// </summary>
        public int EmployeeCount { get; set; }
        // TODO Implement employee count

        /// <summary>
        /// Employees quality rating, from 0 to 100. Slightly influences
        /// the outcome of events (positively or negatively)
        /// </summary>
        public int EmployeeRating { get; set; }
        // TODO Implement employee rating

        /// <summary>
        /// All stocks that are in possession of the company. Rule of thumb:
        /// Companies stop selling if they would lose control of 50% + 1
        /// of the total stocks.
        /// </summary>
        public virtual Portfolio StockReserve { get; set; }
        // TODO Implement 50% + 1 rule


        /// <summary>
        /// Economical sector. Main driver for economical events.
        /// </summary>
        public virtual EconomicSector Sector { get; set; }
        // TODO Implement Sector stability and Sector status (positive, negative)

        /// <summary>
        /// List of all existing stocks.
        /// </summary>
        public virtual ICollection<Stock> Stocks { get; set; }

        public virtual ICollection<SellingOffer> SellingOffers { get; set; }
    }
}
