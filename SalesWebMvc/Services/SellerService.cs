using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Context;
using SalesWebMvc.Models;
using SalesWebMvc.Services.Exceptions;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Seller>> FindAllAsync()
        {
            return await _context.Seller.ToListAsync();
        }

        public async Task InsertAsync(Seller seller)
        {
            _context.Add(seller);

            await _context.SaveChangesAsync();
        }

        public async Task<Seller> FindByIdAsync(int id)
        {
            return await _context.Seller.Include(obj => obj.Department).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task RemoveAsync(int id)
        {
            try
            {
                var seller = await _context.Seller.FindAsync(id);
                var allsales = await _context.SalesRecord.ToListAsync();
                if (seller.Sales.Any())
                {
                    throw new DbUpdateException();
                }
                _context.Remove(seller);
                await _context.SaveChangesAsync();

            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException("Can't delete this seller because they have salles attached to them.");

            }


        }
        public async Task UpdateAsync(Seller s)
        {
            bool hasAny = await _context.Seller.AnyAsync(x => x.Id == s.Id);
            if (!hasAny)
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(s);
                await _context.SaveChangesAsync();
            }
            catch (DbConcurrencyException ex)
            {
                throw new DbConcurrencyException(ex.Message);
            }


        }
    }
}
