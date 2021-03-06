using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Helios.Auditing.Dto;
using Helios.Dto;

namespace Helios.Auditing
{
    public interface IAuditLogAppService : IApplicationService
    {
        Task<PagedResultDto<AuditLogListDto>> GetAuditLogs(GetAuditLogsInput input);

        Task<FileDto> GetAuditLogsToExcel(GetAuditLogsInput input);
    }
}