

using System;
using GroceryHub.API.Tests.Context;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestSharp;
using TechTalk.SpecFlow;

namespace GroceryHub.API.Tests.Steps
{
    [Binding]
    public sealed class HttpSteps
    {
        [When(@"I GET '(.*)'")]
        public void WhenIGET(string url)
        {
            ExecuteHttp(Method.GET, url, "");
        }

        [Then(@"the status should be (.*)")]
        public void ThenTheStatusShouldBe(int expected)
        {
            Assert.AreEqual(expected, HttpContext.Get().StatusCode, "Incorrect HTTP status code");
        }

        private static void ExecuteHttp(Method method, string url, string bodyString)
        {
            var request = new RestRequest(PrepareUrl(url), method);
            request.UseDefaultCredentials = true;
            request.AddHeader("Accept", "application/json");
            request.AddHeader("ContentType", "application/json");
            request.AddParameter("application/json", GroceryHubFeatureContext.Get().SubstitueKeys(bodyString), ParameterType.RequestBody);
        }

        private static string PrepareUrl(string url)
        {
            var resource = GroceryHubFeatureContext.Get().SubstitueKeys(url);
            Console.WriteLine("URL: " + resource);
            return resource;
        }
    }
}
