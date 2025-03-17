using RegisterLoginJWTMTO20.Services;
using System.Resources;

namespace RegisterLoginJWTMTO20
{
    public static class ResourceHelper
    {
        public static string GetResource(string resourceName)
        {
            var resourceManager = new ResourceManager("RegisterLoginJWTMTO20.Properties.Resource", typeof(ResourceHelper).Assembly);
            var resourceValue = resourceManager.GetString(resourceName);
            return resourceValue;
        }
    }
}
