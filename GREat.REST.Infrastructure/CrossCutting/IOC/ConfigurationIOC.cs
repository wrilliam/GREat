using Autofac;
using GREat.REST.Application;
using GREat.REST.Application.Interfaces;
using GREat.REST.Application.Interfaces.Mappers;
using GREat.REST.Application.Mappers;
using GREat.REST.Domain.Core.Interfaces.Repositories;
using GREat.REST.Domain.Core.Interfaces.Services;
using GREat.REST.Domain.Services;
using GREat.REST.Infrastructure.Data.Repositories;

namespace GREat.REST.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceCustomer>().As<IApplicationServiceCustomer>();
            builder.RegisterType<ApplicationServiceProduct>().As<IApplicationServiceProduct>();
            builder.RegisterType<ServiceCustomer>().As<IServiceCustomer>();
            builder.RegisterType<ServiceProduct>().As<IServiceProduct>();
            builder.RegisterType<RepositoryCustomer>().As<IRepositoryCustomer>();
            builder.RegisterType<RepositoryProduct>().As<IRepositoryProduct>();
            builder.RegisterType<MapperCustomer>().As<IMapperCustomer>();
            builder.RegisterType<MapperProduct>().As<IMapperProduct>();

            #endregion IOC
        }
    }
}