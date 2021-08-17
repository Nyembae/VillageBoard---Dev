using System.Threading.Tasks;
using Villageboard.Models.TokenAuth;
using Villageboard.Web.Controllers;
using Shouldly;
using Xunit;

namespace Villageboard.Web.Tests.Controllers
{
    public class HomeController_Tests: VillageboardWebTestBase
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