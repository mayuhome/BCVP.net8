using BCVP.net8.Model;
using BCVP.net8.Repository.Base;
using Newtonsoft.Json;

namespace BCVP.net8.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class, new()
    {
        public async Task<List<TEntity>> Query()
        {
            await Task.CompletedTask;
            var data = "[{\"Id\":18, \"Name\":\"laozhang\"}]";
            return JsonConvert.DeserializeObject<List<TEntity>>(data) ?? new List<TEntity>();
        }
    }
}
