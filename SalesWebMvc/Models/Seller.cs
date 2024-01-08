using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="{0} is required")]
        [StringLength(60,MinimumLength =3,ErrorMessage ="{0} should be between {2} and {1} characters")]
        public string Name { get; set; }
        
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.Date)]
        [Display(Name="Birth Date")]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Base Salary")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        public double BaseSalary { get; set; }


        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void addSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void removeSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double totalSales(DateTime initial, DateTime final)
        {
            var sumOfSales = Sales.
                Where(s => s.Date <= final && s.Date >= initial).
                Sum(s => s.Amount);
            return sumOfSales;
        }

    }
}