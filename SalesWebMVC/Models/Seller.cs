using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "'{0}' é obrigatório.")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O tamanho do nome deve ter entre 3 e 60 caractéres.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "'{0}' é obrigatório.")]
        [EmailAddress(ErrorMessage = "Entre com um e-mail válido")]
        [DisplayName("E-mail")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required(ErrorMessage = "'{0}' é obrigatório.")]
        [DisplayName("Birth date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime birthDate { get; set; }

        [Required(ErrorMessage = "'{0}' é obrigatório.")]
        [Range(100.0, 50000.0, ErrorMessage = "O salário deve estar entre {1} e {2}.")]
        [DisplayName("Base salary")]
        //[DisplayFormat(DataFormatString = "{0:F2}")]
        [DataType(DataType.Currency)]
        public double baseSalary { get; set; }

        [DisplayName("Category")]
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        public ICollection<SalesRecord>? Sales { get; set; } = new List<SalesRecord>();
        public Seller()
        {
        }
        public Seller(int id, string? name, string? email, DateTime birthDate, double baseSalary, Department? department)
        {
            Id = id;
            Name = name;
            Email = email;
            this.birthDate = birthDate;
            this.baseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }

    }
}
