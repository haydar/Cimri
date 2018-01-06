using Cimri.Data.Context;
using Cimri.Entity;
using Cimri.Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cimri.Data.Repository
{
    public class StockRepository:BaseRepository<Stock>
    {
        CimriContext context = new CimriContext();
        public ICollection<StockDto.StockHeader> FillDataGrid(int userCompanyId)
        {
            var query = from stocks in context.Stocks
                        where stocks.isActive==true
                        select new StockDto.StockHeader()
                        {
                            StockId = stocks.StockId,
                            StockName = stocks.StockName,
                            Quantity = context.ProductTransactions.Where(c=>
                            stocks.StockId==c.StockId).Sum(c=>c.ProductNumber)
                        };
            return query.ToList();
        }
    }
}
