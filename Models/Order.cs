using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace CafeOrderingSystem.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [DisplayAttribute(Name = "Notes")]
        [Required]
        public string OrderName { get; set; }
        [Required]
        public int Quantity { get; set; }
        [DisplayAttribute(Name = "Product")]
        public int ProductId { get; set; }
        [DisplayAttribute(Name = "Customer")]
        public int CustomerId { get; set; }
        public virtual Product Product { get; set; }
        public virtual Customer Customer { get; set; }

    }
}