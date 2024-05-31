using BCVP.net8.IService;
using BCVP.net8.Model;
using BCVP.net8.Repository;

namespace BCVP.net8.Service
{
    public class UserService : IUserService
    {
        public async Task<List<UserVo>> Query()
        {
            var userRepo = new UserRepository();
            var users = await userRepo.Query();
            return users.Select(d => new UserVo() { UserName = d.Name }).ToList();
        }
    }
}
