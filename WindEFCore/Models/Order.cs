using System;
using System.Collections.Generic;
using System.Text;

namespace WindEFCore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string ReferenceNumber { get; set; }
        public decimal Price { get; set; }
        public Currency Currency { get; set; }

        //many to many relation
        //public ICollection<Trip> Trips { get; set; }
        public virtual ICollection<TripOrders> TripOrders { get; set; }

        //FK pt client
        public int ClientId { get; set; }
        //one to many relation
        public virtual Company Client { get; set; }
    }
}
