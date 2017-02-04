using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    class Product
    {
        public string nimi { get; set; }
        public float hinta { get; set; }
        public List<Product> tuotteet = new List<Product>();
        public Product(string name, float price)
        {
            nimi = name;
            hinta = price;
        }
    }
}
