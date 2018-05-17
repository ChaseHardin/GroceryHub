using GroceryHub.API.Tests.Infrastructure;
using GroceryHub.Data.Models;
using TechTalk.SpecFlow;

namespace GroceryHub.API.Tests.Context
{
    public class GroceryHubFeatureContext
    {
        public UserProfile UserProfile { get; set; }
        private readonly Substituter _substituter = new Substituter();

        public GroceryHubFeatureContext AddSubstitute(string key, string value)
        {
            _substituter.AddSubstitute(key, value);
            return this;
        }

        public string SubstitueKeys(string s)
        {
            return _substituter.SubstitueKeys(s);
        }

        public static GroceryHubFeatureContext Get()
        {
            GroceryHubFeatureContext ctx;
            return ScenarioContext.Current.TryGetValue(out ctx) ? ctx : NewContext();
        }

        private static GroceryHubFeatureContext NewContext()
        {
            var ctx = new GroceryHubFeatureContext();
            ScenarioContext.Current.Set(ctx);
            return ctx;
        }
    }
}
