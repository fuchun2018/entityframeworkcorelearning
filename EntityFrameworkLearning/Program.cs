using System;
using System.IO;
using EntityFrameworkLearning.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EntityFrameworkLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var configuration = builder.Build();
            var serviceProvider = new ServiceCollection()
                .AddDbContext<BlogContext>(options =>
                    {
                        options.UseSqlServer(configuration.GetConnectionString("DevConnection"));
                    }
                ).BuildServiceProvider();
            using (var context = serviceProvider.GetService<BlogContext>())
            {
                context.Database.EnsureCreated();
                var tableCreator = context.Database.GetService<IDatabaseCreator>();
                ((RelationalDatabaseCreator)tableCreator).CreateTables();
            }
        }
    }
}
