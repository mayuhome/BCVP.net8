using BCVP.net8.Model;

namespace BCVP.net8.IService
{
    public interface IUserService
    {
        Task<List<UserVo>> Query();
    }
}
