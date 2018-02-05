using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneVanzari.Exceptions
{
    class InvalidExpirationDateException: Exception
    {
        public DateTime ExpirationDate { get; set; }
        public InvalidExpirationDateException(DateTime expirationDate)
        {
            ExpirationDate = expirationDate;
        }
    }
}
