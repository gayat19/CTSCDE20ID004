using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyFirstAPIProject.Models
{
    public class Customer
    {
        [Key]
        
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Name Cannot be empty")]
        public string Name { get; set; }
        public bool IsOldCustomer { get; set; }
        [Required(ErrorMessage = "Phone Cannot be empty")] 
        public string Phone { get; set; }

        public IEnumerable<Bill> Bills { get; set; }
    }
}
