﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCVP.net8.IService
{
    public interface IBaseService<TEntity,TVo> where TEntity : class, new()
    {
        public Task<List<TVo>> Query();
    }
}
