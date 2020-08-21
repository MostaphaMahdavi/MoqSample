using System;
using System.Threading.Tasks;
using Mock.Domains.Customers.Entities;
using Mock.Domains.Customers.Enums;
using Mock.Domains.Customers.Repositories;
using Mock.Services.Customers.Handlers;
using Xunit;
using Moq;

namespace Mock.Services.Test
{
    public class GetDiscountServiceTest
    {
        [Fact]
        public void When_CustomerTypeIsUsual_Get1000()
        {

            //For One Request 1
          //  Mock<ICustomerRepositoryQuery> mockCustomerRepository=new Mock<ICustomerRepositoryQuery>();

          //  GetDiscountService discount=new GetDiscountService(mockCustomerRepository.Object);

          //  //One Way
          ////  mockCustomerRepository.Setup(c => c.Get(1)).ReturnsAsync(new Customer(){CustomerType = CustomerType.usual});

          //  //Second Way
          //  mockCustomerRepository.Setup(c => c.Get(1)).Returns(Task.FromResult(new Customer(){CustomerType = CustomerType.usual}));



          //  var result=  discount.Execute(1).Result;

          //  Assert.Equal(1000,result);
            


            //ForAny Request 
            
            Mock<ICustomerRepositoryQuery> mockCustomerRepository=new Mock<ICustomerRepositoryQuery>();
            mockCustomerRepository.Setup(c => c.Get(It.IsAny<int>())).Returns(Task.FromResult(new Customer()
            {
                CustomerType = CustomerType.silver
            }));

            GetDiscountService discount=new GetDiscountService(mockCustomerRepository.Object);
            var result = discount.Execute(1).Result;
            Assert.Equal(2000,result);

        }

        [Fact]
        public void TestOutPutParamiters()
        {
            Mock<ICustomerRepositoryQuery> mockCustomerRepository=new Mock<ICustomerRepositoryQuery>();
            bool result = true;
            mockCustomerRepository.Setup(c => c.IsValidCustomer(out result));

            IsValidCustomerService validCustomerService=new IsValidCustomerService(mockCustomerRepository.Object);
            var res=validCustomerService.Execute(1).Result;
           
            Assert.True(res);


        }

    }
}
