using GestiuneVanzari.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestiuneVanzari.Entities
{
   [Serializable]
    public class Client
    {
        public string ClientId { get; set; }
        public string _firstName;
        public string _lastName;
        public string _phone;
        public string _email;
        public string Adress { get; set; }
        public string City { get; set; }

        public string FirstName
        {
            get { return _firstName ; }
            set
            {
                if (value == "")
                    throw new InvalidNameException(value);
                else
                    _firstName = value;
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (value == "")
                    throw new InvalidNameException(value);
                else
                    _lastName = value;
            }
        }
        public string Phone
        {
            get { return _phone; }
            set
            {
                if (value.Length < 10 || value.Length >10)
                    throw new InvalidPhoneException(value);
                else
                    _phone = value;
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (value=="")
                    throw new InvalidEmailException(value);
                else
                    _email= value;
            }
        }
       public Client()
        {
        }
       public Client(string id,string fn, string ln, string phone, string email, string adress, string city)
       {
           ClientId = id;
           FirstName = fn;
           LastName = ln;
           Phone = phone;
           Email = email;
           Adress = adress;
           City = city;
       }
    }
}
