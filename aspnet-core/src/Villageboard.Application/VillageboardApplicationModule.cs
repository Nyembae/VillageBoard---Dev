using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Villageboard.Authorization;

namespace Villageboard
{
    [DependsOn(
        typeof(VillageboardCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class VillageboardApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<VillageboardAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(VillageboardApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
