using Abp.Application.Services;
using Villageboard.MultiTenancy.Dto;

namespace Villageboard.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

