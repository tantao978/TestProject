using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace VideoSite.Pages
{
    public class Index_Tests : VideoSiteWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
