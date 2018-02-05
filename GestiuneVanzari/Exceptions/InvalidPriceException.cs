using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneVanzari.Exceptions
{
    class InvalidPriceException : Exception
    {
        public decimal Price { get; set; }
        public InvalidPriceException(decimal price)
        {
            Price = price;
        }
    }
}
