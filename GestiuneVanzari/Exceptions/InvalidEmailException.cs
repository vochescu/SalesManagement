using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneVanzari.Exceptions
{
    class InvalidEmailException:Exception
    {
        public string Email { get; set; }
        public InvalidEmailException(string email)
        {
            Email = email;
        }
    }
}
