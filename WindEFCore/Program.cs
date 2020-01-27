using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using WindEFCore.Models;
using static System.Console;

namespace WindEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new WindDbContext();

            var companies = context.Companies
                //.Include(c => c.Orders)
                .Where(c => c.CompanyId > 0)
                .ToList();

            var companyIDs = companies.Select(c => c.CompanyId);

            context.Orders.Load();
            context.Orders.Load();

            WriteLine(companies.First().Orders.Count);
            
            foreach (var company in companies)
            {
                foreach (var order in company.Orders.ToList())
                {
                    WriteLine(order.ReferenceNumber);
                }
            }
            

            //foreach (var order in company.Orders)
            //{
            //    WriteLine(order.ReferenceNumber);
            //}

        }
    }
}
