using GREat.REST.Domain.Core.Interfaces.Repositories;
using GREat.REST.Domain.Core.Interfaces.Services;
using GREat.REST.Domain.Entities;

namespace GREat.REST.Domain.Services
{
    public class ServiceProduct : ServiceBase<Product>, IServiceProduct
    {
        private readonly IRepositoryProduct repositoryProduct;

        public ServiceProduct(IRepositoryProduct repositoryProduct)
            : base(repositoryProduct)
        {
            this.repositoryProduct = repositoryProduct;
        }
    }
}