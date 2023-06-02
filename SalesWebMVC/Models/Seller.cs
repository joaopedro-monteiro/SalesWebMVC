using System.ComponentModel;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        [DisplayName("E-mail")]
        public string? Email { get; set; }

        [DisplayName("Birth date")]
        public DateTime birthDate { get; set; }

        [DisplayName("Base salary")]
        public double baseSalary { get; set; }
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
