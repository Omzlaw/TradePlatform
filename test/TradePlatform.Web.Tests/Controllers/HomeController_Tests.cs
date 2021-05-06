using System.Threading.Tasks;
using TradePlatform.Models.TokenAuth;
using TradePlatform.Web.Controllers;
using Shouldly;
using Xunit;

namespace TradePlatform.Web.Tests.Controllers
{
    public class HomeController_Tests: TradePlatformWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}