using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneVanzari.Exceptions
{
    class InvalidQuantityException:Exception
    {
        public int Quantity{get;set;}
        public InvalidQuantityException(int quantity)
        {
            Quantity=quantity;
        }
    }
}
