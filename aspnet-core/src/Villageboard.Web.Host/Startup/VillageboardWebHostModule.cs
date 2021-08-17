using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Villageboard.Configuration;

namespace Villageboard.Web.Host.Startup
{
    [DependsOn(
       typeof(VillageboardWebCoreModule))]
    public class VillageboardWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public VillageboardWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(VillageboardWebHostModule).GetAssembly());
        }
    }
}
