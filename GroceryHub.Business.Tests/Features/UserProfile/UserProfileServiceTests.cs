using System.Linq;
using GroceryHub.Business.Features.UserProfile;
using GroceryHub.Data.DataGenerators;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GroceryHub.Business.Tests.Features.UserProfile
{
    [TestClass]
    public class UserProfileServiceTests
    {
        [TestMethod]
        public void GetProfile_returns_chase_and_makenna()
        {
            var actual = new UserProfileService().GetProfile();

            var expectedChase = UserProfileData.ChaseProfile();
            var expectedMakenna = UserProfileData.MakennaProfile();
            var actualChase = actual.First(x => x.Id == expectedChase.Id);
            var actualMakenna = actual.First(x => x.Id == expectedMakenna.Id);
            
            Assert.AreEqual(2, actual.Count());

            Assert.AreEqual(expectedChase.Id, actualChase.Id);
            Assert.AreEqual(expectedChase.FirstName, actualChase.FirstName);
            Assert.AreEqual(expectedChase.LastName, actualChase.LastName);
            Assert.AreEqual(expectedChase.AccessToken, actualChase.AccessToken);
            Assert.AreEqual(expectedChase.EntryDate.Date, actualChase.EntryDate.Date);

            Assert.AreEqual(expectedMakenna.Id, actualMakenna.Id);
            Assert.AreEqual(expectedMakenna.FirstName, actualMakenna.FirstName);
            Assert.AreEqual(expectedMakenna.LastName, actualMakenna.LastName);
            Assert.AreEqual(expectedMakenna.AccessToken, actualMakenna.AccessToken);
            Assert.AreEqual(expectedMakenna.EntryDate.Date, actualMakenna.EntryDate.Date);
        }
    }
}
