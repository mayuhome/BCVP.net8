﻿using BCVP.net8.Model;
using Newtonsoft.Json;

namespace BCVP.net8.Repository
{
    public class UserRepository : IUserRepository
    {
        public async Task<List<User>> Query()
        {
            await Task.CompletedTask;
            var data = "[{\"Id\":18, \"Name\":\"laozhang\"}]";
            return JsonConvert.DeserializeObject<List<User>>(data) ?? new List<User>();
        }
    }
}
