using GREat.REST.Domain.Core.Interfaces.Repositories;
using GREat.REST.Domain.Core.Interfaces.Services;
using GREat.REST.Domain.Entities;

namespace GREat.REST.Domain.Services
{
    public class ServiceCustomer : ServiceBase<Customer>, IServiceCustomer
    {
        private readonly IRepositoryCustomer repositoryCustomer;

        public ServiceCustomer(IRepositoryCustomer repositoryCustomer)
            : base(repositoryCustomer)
        {
            this.repositoryCustomer = repositoryCustomer;
        }
    }
}