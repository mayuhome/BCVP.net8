using AutoMapper;
using BCVP.net8.IService;
using BCVP.net8.Repository;
using BCVP.net8.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCVP.net8.Service
{
    public class BaseService<TEntity, TVo> : IBaseService<TEntity, TVo> where TEntity : class, new()
    {
        private readonly IMapper _mapper;
        private readonly IBaseRepository<TEntity> _baseRepository;

        public BaseService(IMapper mapper, IBaseRepository<TEntity> baseRepository) { 
            _mapper = mapper;
            _baseRepository = baseRepository;
        }
        public async Task<List<TVo>> Query()
        {;
            var entities = await _baseRepository.Query();
            var llout = _mapper.Map<List<TVo>>(entities);
            return llout;
        }
    }
}
