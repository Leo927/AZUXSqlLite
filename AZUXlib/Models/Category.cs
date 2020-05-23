using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AZUXlib.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public Category(string categoryName)
        {
            CategoryName = categoryName;
        }
        private Category() { }
    }
}
