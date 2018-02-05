using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneVanzari.Entities
{
    class Transaction
    {
        public string TransactionId { get; set; }
        public string ProductId { get; set; }
        public string ClientId { get; set; }
        public int Quantity{get;set;}
        public DateTime DateOfTransaction { get; set; }
        public int _status; // maybe enum?! 



    }
}
