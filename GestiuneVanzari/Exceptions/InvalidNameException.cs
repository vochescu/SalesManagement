using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneVanzari.Exceptions
{
    class InvalidNameException : Exception
    {
        public string Name { get; set; }
        public InvalidNameException(string name)
        {
            Name = name;
        }
    }
}
