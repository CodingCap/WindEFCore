using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using StoredProcedureEFCore;
using WindEFCore.Models;
using static System.Console;

namespace WindEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new WindDbContext();
            

            
            ////problema cu lazy loading si explicit loading
            ////LAZY LOADING ceva probleme la debug
            //var companies = context.Companies
            //    .Include(c => c.Orders)
            //    .ThenInclude(o => o.TripOrders)
            //    .Include(c => c.Address)
            //    .Where(c => c.CompanyId > 0).ToList();

            ////var companyIDs = companies.Select(c => c.CompanyId);

            ////context.Orders.Where(o => companyIDs.Contains(o.ClientId)).Load();
            ////context.Addresses.Where(a => companyIDs.Contains(a.AddressId)).Load();

            //foreach (var company in companies)
            //{
            //    WriteLine(company.Address.StreetNumber);
            //    foreach (var order in company.Orders) WriteLine(order.ReferenceNumber);
            //}
            

            
            var clientOrdersCounts = new List<ClientOrdersCount>();

            context.LoadStoredProc("usp_clientCount").Exec(r => clientOrdersCounts = r.ToList<ClientOrdersCount>());
            
            var clientOrdersCountsIQ = context.Set<ClientOrdersCount>().FromSqlRaw("usp_clientCount").AsEnumerable();

            var client = clientOrdersCountsIQ.Where(c => c.ClientName == "WindSoft");

            WriteLine(client.First().ClientName);


        }
    }
}
