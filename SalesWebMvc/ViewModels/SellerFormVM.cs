using SalesWebMvc.Models;
using System.Collections.Generic;

namespace SalesWebMvc.ViewModels
{
    public class SellerFormVM
    {
        public Seller Seller { get; set; }
        public IEnumerable<Department> Departments { get; set; }
    }
}
