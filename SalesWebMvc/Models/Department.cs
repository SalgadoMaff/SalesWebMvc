using NuGet.Protocol.Plugins;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebMvc.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} is required")]
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department() { }
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void addSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double totalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.totalSales(initial, final));
        }

    }
}