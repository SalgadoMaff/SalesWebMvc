using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Context;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class SalesRecordService
    {
        private readonly SalesWebMvcContext _context;

        public SalesRecordService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? min, DateTime? max)
        {
            var result = from obj in _context.SalesRecord select obj;
            if (min.HasValue)
            {
                result = result.Where(x => x.Date >= min.Value);
            }
            if (max.HasValue)
            {
                result = result.Where(x => x.Date <= max.Value);

            }
            return await result.Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
        public List<MergedTable> FindByDateGrouping(DateTime? min, DateTime? max)
        {
            var s = (from obj in _context.Seller select obj).ToList();
            var d = (from obj in _context.Department select obj).ToList();
            var result = (from obj in _context.SalesRecord select obj).ToList();
            if (min.HasValue)
            {
                result.RemoveAll(x => x.Date < min.Value);
            }
            if (max.HasValue)
            {
                result.RemoveAll(x => x.Date > max.Value);
            }
            List<MergedTable> ret = new List<MergedTable>();
            foreach (var item in result)
            {
                var sellerAux = s.Find(x => x.Id == item.Seller.Id);
                var depAux = d.Find(x => x.Id == sellerAux.Id);
                ret.Add(new MergedTable
                {
                    DepartmentId = depAux.Id,
                    DepartmentName = depAux.Name,
                    SellerName = sellerAux.Name,
                    SaleAmount = item.Amount,
                    SaleStatus = item.Status,
                    Date = item.Date

                });

            }
            ret.OrderBy(x => x.DepartmentId);
            int i = 0;
            var limit = (from obj in ret select obj.DepartmentId).ToList().Max();
            while (i < limit)
            {
                var sum = (from obj in ret where (obj.DepartmentId == i + 1) select obj.SaleAmount).Sum();
                foreach(var item in ret)
                {
                    if (item.DepartmentId == i + 1)
                    {
                        item.DepartmentTotalSales = (float)sum;
                    }
                }
                i++;
            }
            return ret;
            /*
            return result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Department)
                .OrderByDescending(x => x.Date)
                .GroupBy(x => x.Seller.Department)
                .ToList();
            */


        }
    }
}
