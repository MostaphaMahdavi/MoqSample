using System.Threading.Tasks;

namespace Mock.Domains.Customers.Queries
{
    public interface IGetDiscountService
    {
        Task<int> Execute(int customerId);
    }
}