using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CafeOrderingSystem.Models
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayAttribute(Name = "Product")]
        [Required]
        public string ProductName { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}