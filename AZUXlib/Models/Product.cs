using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZUXlib.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName{ get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public decimal DefaultPrice { get; set; }
        public decimal MaximumRetailPrice { get; set; }
    }


}
