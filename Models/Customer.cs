using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CafeOrderingSystem.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [DisplayAttribute(Name = "Name")]
        [Required]
        public string CustomerName { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}