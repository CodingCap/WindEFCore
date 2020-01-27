using System;
using System.Collections.Generic;
using System.Text;

namespace WindEFCore.Models
{
    public class Trip
    {
        public int TripId { get; set; }
        public string TripReference { get; set; }
        public decimal Price { get; set; }
        public Currency Currency { get; set; }

        //many to many relation
        //public ICollection<Order> Orders { get; set; }
        public virtual ICollection<TripOrders> TripOrders { get; set; }

        //FK pt carier
        public int CarrierId { get; set; }
        //one to many relation
        public virtual Company Carrier { get; set; }
    }
}
