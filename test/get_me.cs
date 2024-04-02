using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Test
{
    public class TestAPI 
    {
        public static void Main(string[] args)
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.trieve.ai";
            config.AddApiKey("Authorization", "tr-YOUR-API-KEY");

            var apiInstance = new AuthApi(config);

            try
            {
                SlimUser user = apiInstance.GetMe();
                Debug.WriteLine(user);
            }
            catch (ApiException e)
            {
                Debug.WriteLine("Exception when calling AuthApi.GetMe: " + e.Message );
            }
        }
    }
}