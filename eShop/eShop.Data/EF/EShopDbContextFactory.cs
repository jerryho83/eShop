﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace eShop.Data.EF
{
    public class EShopDbContextFactory : IDesignTimeDbContextFactory<eShopDbContext>
    {
        public eShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("eShop");

            var optionsBuilder = new DbContextOptionsBuilder<eShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new eShopDbContext(optionsBuilder.Options);
        }
    }
}
