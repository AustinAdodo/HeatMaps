namespace HeatMaps.Utilities.Sales
{
    public interface ISalesService
    {
        public Task<List<Sale>> GetAll(int pageNumber);
        public Task<List<Sale>> GetSalesOnDate(DateTime date);
        public Task<List<DateTime>> GetDates();
        public Task<Sale> Get(int id);
        public Task<Sale> Get(string SaleId);
        public void Update(int id, Sale newtDetails);
        public void Delete(int id);
        public void Add(Sale details);
    }
}
