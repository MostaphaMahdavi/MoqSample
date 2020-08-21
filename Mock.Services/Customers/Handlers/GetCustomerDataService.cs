using Mock.Domains.Commons.Enums;
using Mock.Domains.Customers.Entities;
using Mock.Domains.Customers.Queries;
using Mock.Domains.Customers.Repositories;
using System.Threading.Tasks;

namespace Mock.Services.Customers.Handlers
{
    public class GetCustomerDataService : IGetCustomerDataService
    {
        private readonly ICustomerRepositoryQuery _repositoryQuery;

        public GetCustomerDataService(ICustomerRepositoryQuery repositoryQuery)
        {
            _repositoryQuery = repositoryQuery;
        }
        public async Task<Customer> Execute(int customerId, DbEngine dbEngine)
        {
            Customer customer = new Customer();
            switch (dbEngine)
            {
                case DbEngine.SqlServer:
                    customer = await _repositoryQuery.GetFromSqlServer(customerId);
                    break;
                case DbEngine.MongoDb:
                    customer = await _repositoryQuery.GetFromMongoDb(customerId);
                    break;
            }


            return customer;
        }
    }
}