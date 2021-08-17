using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Villageboard.Authorization.Roles;
using Villageboard.Authorization.Users;
using Villageboard.MultiTenancy;

namespace Villageboard.EntityFrameworkCore
{
    public class VillageboardDbContext : AbpZeroDbContext<Tenant, Role, User, VillageboardDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public VillageboardDbContext(DbContextOptions<VillageboardDbContext> options)
            : base(options)
        {
        }
    }
}
