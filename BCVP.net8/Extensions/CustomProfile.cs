using AutoMapper;
using BCVP.net8.Model;

namespace BCVP.net8.Extensions
{
    public class CustomProfile: Profile
    {
        public CustomProfile() {
            CreateMap<Role, RoleVo>().ForMember(a => a.RoleName, o => o.MapFrom(d => d.Name));
            CreateMap<RoleVo, Role>().ForMember(a => a.Name, o => o.MapFrom(d => d.RoleName));
        }
    }
}
