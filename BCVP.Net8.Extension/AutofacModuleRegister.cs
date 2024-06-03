using Autofac;
using BCVP.net8.IService;
using BCVP.net8.Repository;
using BCVP.net8.Repository.Base;
using BCVP.net8.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BCVP.Net8.Extension
{
    public class AutofacModuleRegister: Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var basePath = AppContext.BaseDirectory;

            var servicesDllFile = Path.Combine(basePath, "BCVP.Net8.Service.dll");
            var repositoryDllFile = Path.Combine(basePath, "BCVP.Net8.Repository.dll");

            builder.RegisterGeneric(typeof(BaseRepository<>)).As(typeof(IBaseRepository<>)).InstancePerDependency();
            builder.RegisterGeneric(typeof(BaseService<,>)).As(typeof(IBaseService<,>)).InstancePerDependency();

            // 获取Service.dll程序集服务，并注册
            var assemblysServices = Assembly.LoadFrom(servicesDllFile);
            builder.RegisterAssemblyTypes(assemblysServices)
                .AsImplementedInterfaces()
                .InstancePerDependency()
                .PropertiesAutowired();

            // 获取Repository.dll程序集服务，并注册
            var assemblysRepository = Assembly.LoadFrom(repositoryDllFile);
            builder.RegisterAssemblyTypes(assemblysRepository)
                .AsImplementedInterfaces()
                .InstancePerDependency()
                .PropertiesAutowired();
        }
    }
}
