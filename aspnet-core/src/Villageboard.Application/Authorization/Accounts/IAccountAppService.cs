using System.Threading.Tasks;
using Abp.Application.Services;
using Villageboard.Authorization.Accounts.Dto;

namespace Villageboard.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
