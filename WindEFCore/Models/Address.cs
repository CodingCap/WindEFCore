using System;
using System.Collections.Generic;
using System.Text;

namespace WindEFCore.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        
        //one to one relation
        //cam tras de par dar sa zicem ca o firma are o singura adresa
        public virtual Company Company { get; set; }
    }
}
