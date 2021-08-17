using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Villageboard.Configuration;
using Villageboard.Web;

namespace Villageboard.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class VillageboardDbContextFactory : IDesignTimeDbContextFactory<VillageboardDbContext>
    {
        public VillageboardDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<VillageboardDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            VillageboardDbContextConfigurer.Configure(builder, configuration.GetConnectionString(VillageboardConsts.ConnectionStringName));

            return new VillageboardDbContext(builder.Options);
        }
    }
}
