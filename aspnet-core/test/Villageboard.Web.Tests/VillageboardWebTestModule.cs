using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Villageboard.EntityFrameworkCore;
using Villageboard.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Villageboard.Web.Tests
{
    [DependsOn(
        typeof(VillageboardWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class VillageboardWebTestModule : AbpModule
    {
        public VillageboardWebTestModule(VillageboardEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VillageboardWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(VillageboardWebMvcModule).Assembly);
        }
    }
}