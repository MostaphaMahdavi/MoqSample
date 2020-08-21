using Mock.Domains.Customers.Enums;
using Mock.Domains.Customers.Queries;
using Mock.Domains.Customers.Repositories;
using System.Threading.Tasks;

namespace Mock.Services.Customers.Handlers
{
    public class GetDiscountService : IGetDiscountService
    {
        private readonly ICustomerRepositoryQuery _repositoryQuery;

        public GetDiscountService(ICustomerRepositoryQuery repositoryQuery)
        {
            _repositoryQuery = repositoryQuery;
        }


        public async Task<int> Execute(int customerId)
        {
            var customer = await _repositoryQuery.Get(customerId);
            switch (customer.CustomerType)
            {
                case CustomerType.usual:
                    return 1000;
                case CustomerType.silver:
                    return 2000;
                case CustomerType.gold:
                    return 10000;


            }
            return 0;
        }

    }
}