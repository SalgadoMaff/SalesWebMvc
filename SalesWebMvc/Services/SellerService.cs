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

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(p => p.Id == id);
        }

        public void Remove(int id)
        {
            var seller = _context.Seller.Find(id);

            _context.Remove(seller);
            _context.SaveChanges();

        }
        public void Update(Seller s)
        {
            if (!_context.Seller.Any(x => x.Id == s.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(s);
                _context.SaveChanges();
            }
            catch (DbConcurrencyException ex)
            {
                throw new DbConcurrencyException(ex.Message);
            }


        }
    }
}
