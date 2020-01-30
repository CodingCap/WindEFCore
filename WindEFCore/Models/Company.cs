using System;
using System.Collections.Generic;
using System.Text;

namespace WindEFCore.Models
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }

        //one to one relation
        //cam tras de par dar sa zicem ca o firma are o singura adresa
        //Company este PRINCIPAL
        //Address este DEPENDENT
        public virtual Address Address { get; set; }

        //one to many relation
        //poate fi exclus daca nu se doreste ca fiecare firma sa stie de comenzi
        //new HashSet<Order>(); pt a evita duplicatele
        public virtual ICollection<Order> Orders { get; set; }// = new HashSet<Order>();

        //one to many relation
        public virtual ICollection<Trip> Trips { get; set; }// = new HashSet<Trip>();
    }
}
