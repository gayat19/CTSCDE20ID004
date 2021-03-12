using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyFirstAPIProject.Models
{
    public class Bill
    {
        [Key]
        public int BillNumber { get; set; }
        public int CustomerID { get; set; }
        [Required(ErrorMessage = "Amount Cannot be empty")]
        [Range(100,1000000)]
        public float Amount { get; set; }
        public DateTime BillDate { get; set; }

        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }
    }
}
