using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace HeatMaps.Utilities.Sales
{
    public class SalesService : ISalesService
    {
        private readonly ApplicationDbContext _salesContext;

        public SalesService(ApplicationDbContext salesContext)
        {
            _salesContext = salesContext;
        }

        public void Add(Sale details)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Sale> Get(int id)
        {
            var Product = await _salesContext.Sales.FindAsync(id);
            if (Product != null) return Product;
            var result = Enumerable.Empty<Sale>().ToList().First();
            return result;
        }

        public async Task<Sale> Get(string SaleId)
        {
            var detail = await _salesContext.Sales.Where(a => a.SalesId == SaleId).FirstAsync();
            if (detail != null) return detail;
            var result = Enumerable.Empty<Sale>().ToList().First();
            return result;
        }

        public async Task<List<Sale>> GetAll()
        {
            var All = await _salesContext.Sales.ToListAsync();
            if (All != null) return All;
            var result = Enumerable.Empty<Sale>().ToList();
            return result;
        }

        public async Task<List<DateTime>> GetDates()
        {
            var dates = await _salesContext.Sales.Select(a => a.Date).ToListAsync();
            if(dates!=null)return dates;
            dates = Enumerable.Empty<DateTime>().ToList();
            return dates;
        }

        public async void Update(int id, Sale newDetails)
        {
            var result = await _salesContext.Sales.FindAsync(id);
            if (result != null)
            {
                foreach (PropertyInfo prty in typeof(Sale).GetProperties())
                {
                    prty.SetValue(result, prty.GetValue(newDetails));
                }
                _salesContext.Sales.Attach(result);
                _salesContext.Entry(result).State = EntityState.Modified;
            }
            await _salesContext.SaveChangesAsync();
        }
    }
}
