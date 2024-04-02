using System;
using System.Collections.Generic;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class TestAPI
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.trieve.ai";
            config.AddApiKey("Authorization", "tr-YOUR-API-KEY");

            var apiInstance = new ChunkApi(config);

            var tRDataset = "YOUR-DATASET-ID";

            var chunkData = new ChunkData
            {
                ChunkHtml = "<p>This is the body of the article.</p>",
                Link = "https://example.com/article",
                Metadata = new Dictionary<string, object>
                {
                    { "author", "John Doe" },
                    { "cover_image", "https://example.com/cover_image.jpg" },
                    { "title", "Sample Article Title" }
                },
                TagSet = new List<string> { "sample", "test", "fake" },
                TrackingId = "123456789",
                Weight = 100,
                UpsertByTrackingId = true
            };

            try
            {
                var createChunkData = new CreateChunkData(chunkData);
                ReturnQueuedChunk result = apiInstance.CreateChunk(tRDataset, createChunkData);
                Console.WriteLine("====================================");
                Console.WriteLine("CREATED CHUNK!");
                Console.WriteLine("====================================");
                Console.WriteLine(result);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling ChunkApi.CreateChunk: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
