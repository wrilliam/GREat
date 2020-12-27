using GREat.REST.Domain.Core.Interfaces.Repositories;
using GREat.REST.Domain.Entities;

namespace GREat.REST.Infrastructure.Data.Repositories
{
    public class RepositoryCustomer : RepositoryBase<Customer>, IRepositoryCustomer
    {
        private readonly SqlContext sqlContext;

        public RepositoryCustomer(SqlContext sqlContext)
            : base(sqlContext)
        {
            this.sqlContext = sqlContext;
        }
    }
}