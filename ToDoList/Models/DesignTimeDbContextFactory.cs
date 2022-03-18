using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SillystringFactory.Models
{
  public class SillystringFactoryContextFactory : IDesignTimeDbContextFactory<SillystringFactoryContext>
  {

    SillystringFactoryContext IDesignTimeDbContextFactory<SillystringFactoryContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<SillystringFactoryContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new SillystringFactoryContext(builder.Options);
    }
  }
}