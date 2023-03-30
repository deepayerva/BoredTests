using BoredAPITesting.Pages.Home;
using NUnit.Framework;
using System.Threading.Tasks;

namespace BoredAPITesting.Tests
{
    [TestFixture]
    public class BoredAPITests
    {
        [TestCase("https://www.boredapi.com/api/activity?type=social&participants=3", "social", TestName = "APICall_ThreeActivities_SocialType_ThreeParticipants")]
        [TestCase("https://www.boredapi.com/api/activity?type=social&participants=2", "social", TestName = "APICall_ThreeActivities_SocialType_TwoParticipants")]
        public async Task TryItOut(string url, string expectedType)
        {
            var responseData = await TryItOutPage.RequestResponse(url);
            Assert.IsTrue(!string.IsNullOrEmpty(responseData.Type));
            Assert.AreEqual(expectedType, responseData.Type, "type not matched");
        }
    }
}

