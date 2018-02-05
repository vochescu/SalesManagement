using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneVanzari.Exceptions
{
    class InvalidPhoneException:Exception
    {
        public string Phone { get; set; }
        public InvalidPhoneException(string phone)
        {
            Phone = phone;
        }
    }
}
