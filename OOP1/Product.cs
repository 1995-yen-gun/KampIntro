using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; }        //snippet : hazır kodlar ipucunu yazıdıktan sonra özllikleri kendisi listeliyor.

        public int CategoryId { get; set; }

        public string ProductName { get; set; }
        public double  UnitPrice { get; set; }

        public int UnitsInStock { get; set; }
    }

}
