using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Models
{
    public class MergedTable
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public float DepartmentTotalSales { get; set; }
        public DateTime Date { get; set; }
        public double SaleAmount { get; set; }
        public string SellerName { get; set; }
        public SaleStatus SaleStatus { get; set; }


    }
}
