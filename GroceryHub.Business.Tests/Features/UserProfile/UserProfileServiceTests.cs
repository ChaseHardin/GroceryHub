using System.Linq;
using GroceryHub.Business.Features.UserProfile;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GroceryHub.Business.Tests.Features.UserProfile
{
    [TestClass]
    public class UserProfileServiceTests
    {
        [TestMethod]
        public void GetProfile_returns_chase_and_makenna()
        {
            var service = new UserProfileService();
            var actual = service.GetProfile();

            var chase = actual.First(x => x.FirstName.ToLower() == "chase");
            var makenna = actual.First(x => x.FirstName.ToLower() == "makenna");

            Assert.AreEqual(actual.Count(), 2);
            Assert.AreEqual(chase.FirstName, "Chase");
            Assert.AreEqual(chase.LastName, "Hardin");
            Assert.AreEqual(makenna.FirstName, "Makenna");
            Assert.AreEqual(makenna.LastName, "Ridgway");
        }
    }
}
