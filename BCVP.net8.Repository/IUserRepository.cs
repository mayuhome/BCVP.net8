using BCVP.net8.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCVP.net8.Repository
{
    internal interface IUserRepository
    {
        Task<List<User>> Query();
    }
}
