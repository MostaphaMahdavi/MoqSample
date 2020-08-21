using Microsoft.Extensions.DependencyInjection;
using Mock.DataLayerCommands.Customers.Repositories;
using Mock.DataLayerQueries.Repositories;
using Mock.Domains.Customers.Queries;
using Mock.Domains.Customers.Repositories;
using Mock.Services.Customers.Handlers;

namespace Mock.Presentation.Extensions.Iocs
{
    public static class IocExtension
    {

        public static IServiceCollection AddIocExtension(this IServiceCollection services)
        {

            services.AddScoped<ICustomerRepositoryCommand, CustomerRepositoryCommand>();
            services.AddScoped<ICustomerRepositoryQuery, CustomerRepositoryQuery>();


            services.AddScoped<IGetDiscountService, GetDiscountService>();
            services.AddScoped<IGetCustomerDataService, GetCustomerDataService>();

            return services;
        }
    }
}