using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using WindEFCore.Models;
using static System.Console;

namespace WindEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new WindDbContext();
            var company = context.Companies.First(c => c.CompanyId == 3);


            var companyToUpdate = context.Companies.Find(3);
            company.CompanyName = "test";

            context.Entry(companyToUpdate).OriginalValues["RowVersion"] = context.Entry(company)
                .OriginalValues["RowVersion"];
            try
            {
                context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException  e)
            {
                Console.WriteLine(e);
            }
            

        }
    }
}
