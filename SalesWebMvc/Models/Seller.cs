using System;
using System.Linq;
using System.Collections.Generic;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public DateTime BirthDate { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> SalesRecord { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int iD, string email, string name, double baseSalary, DateTime birthDate, Department department)
        {
            ID = iD;
            Email = email;
            Name = name;
            BaseSalary = baseSalary;
            BirthDate = birthDate;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            SalesRecord.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            SalesRecord.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return SalesRecord.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
