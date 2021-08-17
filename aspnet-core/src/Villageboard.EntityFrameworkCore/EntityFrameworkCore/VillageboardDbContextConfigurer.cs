using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Villageboard.EntityFrameworkCore
{
    public static class VillageboardDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<VillageboardDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<VillageboardDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
