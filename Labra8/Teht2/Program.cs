using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> tuotteet = new List<Product>();
            Product maito = new Product("maito", (float)10.1);
            tuotteet.Add(maito);
            foreach (Product product in tuotteet)
            {
                Console.WriteLine(product.nimi + " " + product.hinta + "e");
            }

        }
    }
}
