using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace SweetsAndTreats.Models
{
  public class SweetsAndTreatsContextFactory : IDesignTimeDbContextFactory<SweetsAndTreatsContext>
  {

    SweetsAndTreatsContext IDesignTimeDbContextFactory<SweetsAndTreatsContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<SweetsAndTreatsContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new SweetsAndTreatsContext(builder.Options);
    }
  }
}