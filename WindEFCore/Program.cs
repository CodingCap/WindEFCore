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
            
            

            var res = context.Set<ClientOrdersCount>()
                .FromSqlRaw("exec dbo.usp_clientCount");
        }
    }
}
