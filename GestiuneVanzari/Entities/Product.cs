using GestiuneVanzari.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneVanzari.Entities
{
    [Serializable]
  
    public class Product
    {
        public static int idGenerator;
        public string ProductId { get; set; }
        public string _name { get; set; }
        public string Description { get; set; }
        public decimal _price { get; set; }
        public DateTime _expirationDate;

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == "")
                    throw new InvalidNameException(value);
                else
                    _name = value;
            }
        }
        public DateTime ExpirationDate
        {
            get { return _expirationDate; }
            set
            {
                if(DateTime.Now>value)
                    throw new InvalidExpirationDateException(value);
                else
                    _expirationDate = value;
            }
        }
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value <= 0)
                    throw new InvalidPriceException(value);
                else
                    _price = value;
            }
        }
      
        public Product()
        {
          
        }
        public Product(string id,string name, string description,decimal price, DateTime expirationDate)
        {
            ProductId = id;
            Name = name;
            Description = description;
            Price = price;
            ExpirationDate = expirationDate;
        }
        public Product(string name, string description, decimal price, DateTime expirationDate)
        {
            idGenerator++;
            ProductId = idGenerator.ToString();
            Name = name;
            Description = description;
            Price = price;
            ExpirationDate = expirationDate;
        }
    }
   
}
