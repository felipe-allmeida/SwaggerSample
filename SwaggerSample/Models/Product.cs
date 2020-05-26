using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerSample.Models
{
    public class Product
    {
        public Product() { }
        public Product(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
        [Required]
        public string Name { get; set; }
        [DefaultValue("No description")]
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
