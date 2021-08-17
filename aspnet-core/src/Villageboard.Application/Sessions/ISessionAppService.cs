using System.Threading.Tasks;
using Abp.Application.Services;
using Villageboard.Sessions.Dto;

namespace Villageboard.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
