namespace GroceryHub.Data
{
    public class Application
    {
        public static GroceryHubEntity GetDatabaseInstance()
        {
            return new GroceryHubEntity();
        }
    }
}