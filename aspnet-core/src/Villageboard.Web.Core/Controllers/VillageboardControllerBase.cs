using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Villageboard.Controllers
{
    public abstract class VillageboardControllerBase: AbpController
    {
        protected VillageboardControllerBase()
        {
            LocalizationSourceName = VillageboardConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
