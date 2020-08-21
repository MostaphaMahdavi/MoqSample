using System.Threading.Tasks;
using Mock.Domains.Customers.Queries;
using Mock.Domains.Customers.Repositories;

namespace Mock.Services.Customers.Handlers
{
    public class IsValidCustomerService:IIsValidCustomerService
    {
        private ICustomerRepositoryQuery _customerRepositoryQuery;

        public IsValidCustomerService(ICustomerRepositoryQuery customerRepositoryQuery)
        {
            _customerRepositoryQuery = customerRepositoryQuery;
        }
        public async Task<bool> Execute(int customerId)
        {
             await _customerRepositoryQuery.IsValidCustomer(out bool temp);
             return temp;

        }
    }
}