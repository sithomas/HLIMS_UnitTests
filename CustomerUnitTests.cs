using Xunit;
using Moq;
using HLIMS_API_MicroServices.Domain.Services;
using System.Threading.Tasks;
namespace HLIMS_API_MICROSERVICES_UNITTESTS
{
    public class CustomerUnitTests
    {
        
        [Theory]
        [InlineData("SBI","SBI_sijuthomasp+1@gmail.com_8848542724_01012019", true)]
        public void Testing(string bankName, string loanID, bool valueToCheck)
        {
           ICustomerService _customerService;
            var result = _customerService.GetCustomerAsync(bankName, loanID);
            Assert.True (result.Response.RequestSuccessful);

          
        }
       
    }
}
