using Mock.Domains.Customers.Enums;

namespace Mock.Domains.Customers.Entities
{
    public class Customer
    {

        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public CustomerType CustomerType { get; set; }

    }
}