using Abp.AutoMapper;
using SpeedTest.Sessions.Dto;

namespace SpeedTest.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}