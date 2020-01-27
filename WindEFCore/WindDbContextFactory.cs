using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace WindEFCore
{
    //class WindDbContextFactory : IDesignTimeDbContextFactory<WindDbContext>
    //{
    //    private static string _connectionString;

    //    public WindDbContext CreateDbContext()
    //    {
    //        return CreateDbContext(null);
    //    }

    //    public WindDbContext CreateDbContext(string[] args)
    //    {
    //        return new WindDbContext(new DbContextOptionsBuilder<WindDbContext>()
    //            .UseSqlServer(GetConnectionString())
    //            .Options);
    //    }

    //    private static string GetConnectionString()
    //    {
    //        if (!string.IsNullOrEmpty(_connectionString))
    //            return _connectionString;

    //        var configuration = new ConfigurationBuilder()
    //            .AddJsonFile("appsettings.json", false, true)
    //            .Build();

    //        _connectionString = configuration.GetConnectionString("WindDbContext");

    //        return _connectionString;
    //    }
    //}
}
