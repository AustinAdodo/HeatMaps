using System.ComponentModel.DataAnnotations;

namespace HeatMaps
{
    public class Sale
    {
        //independent ID
        [Required]
        public int id { get; set; }
        [Required]
        public string SalesId { get; set; }
        public double Amount { get; set; }
        public int Quantity { get; set; }
        public double SumTotal { get { return Amount * Quantity; } }
        public string? Discription { get; set; }
        public DateTime Date { get; set; }
        public TimeOnly Time { get; set; }

    }
}
