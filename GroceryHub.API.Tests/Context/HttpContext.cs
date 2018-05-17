using RestSharp;
using TechTalk.SpecFlow;

namespace GroceryHub.API.Tests.Context
{
    public class HttpContext
    {
        public int StatusCode { get { return (int)Response.StatusCode; } }
        public IRestResponse Response { get; set; }

        public static HttpContext Get()
        {
            HttpContext ctx;
            return ScenarioContext.Current.TryGetValue(out ctx) ? ctx : NewContext();
        }

        private static HttpContext NewContext()
        {
            var ctx = new HttpContext();
            ScenarioContext.Current.Set(ctx);
            return ctx;
        }
    }
}
