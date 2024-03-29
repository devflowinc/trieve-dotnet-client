# trieve_dotnet_client.Api.ChunkApi

All URIs are relative to *http://localhost:8090*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateChunk**](ChunkApi.md#createchunk) | **POST** /api/chunk | Create or Upsert Chunk or Chunks |
| [**CreateSuggestedQueriesHandler**](ChunkApi.md#createsuggestedquerieshandler) | **POST** /api/chunk/gen_suggestions | Generate suggested queries |
| [**DeleteChunk**](ChunkApi.md#deletechunk) | **DELETE** /api/chunk/{chunk_id} | Delete Chunk |
| [**DeleteChunkByTrackingId**](ChunkApi.md#deletechunkbytrackingid) | **DELETE** /api/chunk/tracking_id/{tracking_id} | Delete Chunk By Tracking Id |
| [**GenerateOffChunks**](ChunkApi.md#generateoffchunks) | **POST** /api/chunk/generate | RAG on Specified Chunks |
| [**GetChunkById**](ChunkApi.md#getchunkbyid) | **GET** /api/chunk/{chunk_id} | Get Chunk By Id |
| [**GetChunkByTrackingId**](ChunkApi.md#getchunkbytrackingid) | **GET** /api/chunk/tracking_id/{tracking_id} | Get Chunk By Tracking Id |
| [**GetRecommendedChunks**](ChunkApi.md#getrecommendedchunks) | **POST** /api/chunk/recommend | Get Recommended Chunks |
| [**SearchChunk**](ChunkApi.md#searchchunk) | **POST** /api/chunk/search | Search |
| [**UpdateChunk**](ChunkApi.md#updatechunk) | **PUT** /api/chunk | Update Chunk |
| [**UpdateChunkByTrackingId**](ChunkApi.md#updatechunkbytrackingid) | **PUT** /api/chunk/tracking_id/update | Update Chunk By Tracking Id |

<a id="createchunk"></a>
# **CreateChunk**
> ReturnQueuedChunk CreateChunk (string tRDataset, CreateChunkData createChunkData)

Create or Upsert Chunk or Chunks

Create or Upsert Chunk or Chunks  Create a new chunk. If the chunk has the same tracking_id as an existing chunk, the request will fail. Once a chunk is created, it can be searched for using the search endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class CreateChunkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var createChunkData = new CreateChunkData(); // CreateChunkData | JSON request payload to create a new chunk (chunk)

            try
            {
                // Create or Upsert Chunk or Chunks
                ReturnQueuedChunk result = apiInstance.CreateChunk(tRDataset, createChunkData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkApi.CreateChunk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateChunkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create or Upsert Chunk or Chunks
    ApiResponse<ReturnQueuedChunk> response = apiInstance.CreateChunkWithHttpInfo(tRDataset, createChunkData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkApi.CreateChunkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **createChunkData** | [**CreateChunkData**](CreateChunkData.md) | JSON request payload to create a new chunk (chunk) |  |

### Return type

[**ReturnQueuedChunk**](ReturnQueuedChunk.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | JSON response payload containing the created chunk |  -  |
| **400** | Error typically due to deserialization issues |  -  |
| **426** | Error when upgrade is needed to process more chunks |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createsuggestedquerieshandler"></a>
# **CreateSuggestedQueriesHandler**
> SuggestedQueriesResponse CreateSuggestedQueriesHandler (string tRDataset, SuggestedQueriesRequest suggestedQueriesRequest)

Generate suggested queries

Generate suggested queries  This endpoint will generate 3 suggested queries based off the query provided in the request body and return them as a JSON object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class CreateSuggestedQueriesHandlerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var suggestedQueriesRequest = new SuggestedQueriesRequest(); // SuggestedQueriesRequest | JSON request payload to get alternative suggested queries

            try
            {
                // Generate suggested queries
                SuggestedQueriesResponse result = apiInstance.CreateSuggestedQueriesHandler(tRDataset, suggestedQueriesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkApi.CreateSuggestedQueriesHandler: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSuggestedQueriesHandlerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generate suggested queries
    ApiResponse<SuggestedQueriesResponse> response = apiInstance.CreateSuggestedQueriesHandlerWithHttpInfo(tRDataset, suggestedQueriesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkApi.CreateSuggestedQueriesHandlerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **suggestedQueriesRequest** | [**SuggestedQueriesRequest**](SuggestedQueriesRequest.md) | JSON request payload to get alternative suggested queries |  |

### Return type

[**SuggestedQueriesResponse**](SuggestedQueriesResponse.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A JSON object containing a list of alternative suggested queries |  -  |
| **400** | Service error relating to to updating chunk, likely due to conflicting tracking_id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletechunk"></a>
# **DeleteChunk**
> void DeleteChunk (string tRDataset, Guid chunkId)

Delete Chunk

Delete Chunk  Delete a chunk by its id. If deleting a root chunk which has a collision, the most recently created collision will become a new root chunk.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class DeleteChunkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var chunkId = "chunkId_example";  // Guid | Id of the chunk you want to fetch.

            try
            {
                // Delete Chunk
                apiInstance.DeleteChunk(tRDataset, chunkId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkApi.DeleteChunk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteChunkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Chunk
    apiInstance.DeleteChunkWithHttpInfo(tRDataset, chunkId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkApi.DeleteChunkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **chunkId** | **Guid** | Id of the chunk you want to fetch. |  |

### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Confirmation that the chunk with the id specified was deleted |  -  |
| **400** | Service error relating to finding a chunk by tracking_id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletechunkbytrackingid"></a>
# **DeleteChunkByTrackingId**
> void DeleteChunkByTrackingId (string tRDataset, string trackingId)

Delete Chunk By Tracking Id

Delete Chunk By Tracking Id  Delete a chunk by tracking_id. This is useful for when you are coordinating with an external system and want to use the tracking_id to identify the chunk. If deleting a root chunk which has a collision, the most recently created collision will become a new root chunk.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class DeleteChunkByTrackingIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var trackingId = "trackingId_example";  // string | tracking_id of the chunk you want to delete

            try
            {
                // Delete Chunk By Tracking Id
                apiInstance.DeleteChunkByTrackingId(tRDataset, trackingId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkApi.DeleteChunkByTrackingId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteChunkByTrackingIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Chunk By Tracking Id
    apiInstance.DeleteChunkByTrackingIdWithHttpInfo(tRDataset, trackingId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkApi.DeleteChunkByTrackingIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **trackingId** | **string** | tracking_id of the chunk you want to delete |  |

### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Confirmation that the chunk with the tracking_id specified was deleted |  -  |
| **400** | Service error relating to finding a chunk by tracking_id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="generateoffchunks"></a>
# **GenerateOffChunks**
> string GenerateOffChunks (string tRDataset, GenerateChunksRequest generateChunksRequest)

RAG on Specified Chunks

RAG on Specified Chunks  This endpoint exists as an alternative to the topic+message concept where our API handles chat memory. With this endpoint, the user is responsible for providing the context window and the prompt. See more in the \"search before generate\" page at docs.trieve.ai.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class GenerateOffChunksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var generateChunksRequest = new GenerateChunksRequest(); // GenerateChunksRequest | JSON request payload to perform RAG on some chunks (chunks)

            try
            {
                // RAG on Specified Chunks
                string result = apiInstance.GenerateOffChunks(tRDataset, generateChunksRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkApi.GenerateOffChunks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GenerateOffChunksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // RAG on Specified Chunks
    ApiResponse<string> response = apiInstance.GenerateOffChunksWithHttpInfo(tRDataset, generateChunksRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkApi.GenerateOffChunksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **generateChunksRequest** | [**GenerateChunksRequest**](GenerateChunksRequest.md) | JSON request payload to perform RAG on some chunks (chunks) |  |

### Return type

**string**

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | This will be a JSON response of a string containing the LLM&#39;s generated inference. Response if not streaming. |  -  |
| **400** | Service error relating to to updating chunk, likely due to conflicting tracking_id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getchunkbyid"></a>
# **GetChunkById**
> ChunkMetadata GetChunkById (string tRDataset, Guid chunkId)

Get Chunk By Id

Get Chunk By Id  Get a singular chunk by id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class GetChunkByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var chunkId = "chunkId_example";  // Guid | Id of the chunk you want to fetch.

            try
            {
                // Get Chunk By Id
                ChunkMetadata result = apiInstance.GetChunkById(tRDataset, chunkId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkApi.GetChunkById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChunkByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Chunk By Id
    ApiResponse<ChunkMetadata> response = apiInstance.GetChunkByIdWithHttpInfo(tRDataset, chunkId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkApi.GetChunkByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **chunkId** | **Guid** | Id of the chunk you want to fetch. |  |

### Return type

[**ChunkMetadata**](ChunkMetadata.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | chunk with the id that you were searching for |  -  |
| **400** | Service error relating to fidning a chunk by tracking_id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getchunkbytrackingid"></a>
# **GetChunkByTrackingId**
> ChunkMetadata GetChunkByTrackingId (string tRDataset, string trackingId)

Get Chunk By Tracking Id

Get Chunk By Tracking Id  Get a singular chunk by tracking_id. This is useful for when you are coordinating with an external system and want to use your own id as the primary reference for a chunk.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class GetChunkByTrackingIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var trackingId = "trackingId_example";  // string | tracking_id of the chunk you want to fetch

            try
            {
                // Get Chunk By Tracking Id
                ChunkMetadata result = apiInstance.GetChunkByTrackingId(tRDataset, trackingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkApi.GetChunkByTrackingId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChunkByTrackingIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Chunk By Tracking Id
    ApiResponse<ChunkMetadata> response = apiInstance.GetChunkByTrackingIdWithHttpInfo(tRDataset, trackingId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkApi.GetChunkByTrackingIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **trackingId** | **string** | tracking_id of the chunk you want to fetch |  |

### Return type

[**ChunkMetadata**](ChunkMetadata.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | chunk with the tracking_id that you were searching for |  -  |
| **400** | Service error relating to fidning a chunk by tracking_id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrecommendedchunks"></a>
# **GetRecommendedChunks**
> List&lt;ChunkMetadataWithFileData&gt; GetRecommendedChunks (string tRDataset, RecommendChunksRequest recommendChunksRequest)

Get Recommended Chunks

Get Recommended Chunks  Get recommendations of chunks similar to the chunks in the request. Think about this as a feature similar to the \"add to playlist\" recommendation feature on Spotify. This request pairs especially well with our groups endpoint.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class GetRecommendedChunksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var recommendChunksRequest = new RecommendChunksRequest(); // RecommendChunksRequest | JSON request payload to get recommendations of chunks similar to the chunks in the request

            try
            {
                // Get Recommended Chunks
                List<ChunkMetadataWithFileData> result = apiInstance.GetRecommendedChunks(tRDataset, recommendChunksRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkApi.GetRecommendedChunks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecommendedChunksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Recommended Chunks
    ApiResponse<List<ChunkMetadataWithFileData>> response = apiInstance.GetRecommendedChunksWithHttpInfo(tRDataset, recommendChunksRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkApi.GetRecommendedChunksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **recommendChunksRequest** | [**RecommendChunksRequest**](RecommendChunksRequest.md) | JSON request payload to get recommendations of chunks similar to the chunks in the request |  |

### Return type

[**List&lt;ChunkMetadataWithFileData&gt;**](ChunkMetadataWithFileData.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | JSON response payload containing chunks with scores which are similar to those in the request body |  -  |
| **400** | Service error relating to to getting similar chunks |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchchunk"></a>
# **SearchChunk**
> SearchChunkQueryResponseBody SearchChunk (string tRDataset, SearchChunkData searchChunkData)

Search

Search  This route provides the primary search functionality for the API. It can be used to search for chunks by semantic similarity, full-text similarity, or a combination of both. Results' `chunk_html` values will be modified with `<b>` tags for sub-sentence highlighting.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class SearchChunkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var searchChunkData = new SearchChunkData(); // SearchChunkData | JSON request payload to semantically search for chunks (chunks)

            try
            {
                // Search
                SearchChunkQueryResponseBody result = apiInstance.SearchChunk(tRDataset, searchChunkData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkApi.SearchChunk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchChunkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search
    ApiResponse<SearchChunkQueryResponseBody> response = apiInstance.SearchChunkWithHttpInfo(tRDataset, searchChunkData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkApi.SearchChunkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **searchChunkData** | [**SearchChunkData**](SearchChunkData.md) | JSON request payload to semantically search for chunks (chunks) |  |

### Return type

[**SearchChunkQueryResponseBody**](SearchChunkQueryResponseBody.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | chunks which are similar to the embedding vector of the search query |  -  |
| **400** | Service error relating to searching |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatechunk"></a>
# **UpdateChunk**
> void UpdateChunk (string tRDataset, UpdateChunkData updateChunkData)

Update Chunk

Update Chunk  Update a chunk. If you try to change the tracking_id of the chunk to have the same tracking_id as an existing chunk, the request will fail.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class UpdateChunkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var updateChunkData = new UpdateChunkData(); // UpdateChunkData | JSON request payload to update a chunk (chunk)

            try
            {
                // Update Chunk
                apiInstance.UpdateChunk(tRDataset, updateChunkData);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkApi.UpdateChunk: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateChunkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Chunk
    apiInstance.UpdateChunkWithHttpInfo(tRDataset, updateChunkData);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkApi.UpdateChunkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **updateChunkData** | [**UpdateChunkData**](UpdateChunkData.md) | JSON request payload to update a chunk (chunk) |  |

### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No content Ok response indicating the chunk was updated as requested |  -  |
| **400** | Service error relating to to updating chunk, likely due to conflicting tracking_id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatechunkbytrackingid"></a>
# **UpdateChunkByTrackingId**
> void UpdateChunkByTrackingId (string tRDataset, UpdateChunkByTrackingIdData updateChunkByTrackingIdData)

Update Chunk By Tracking Id

Update Chunk By Tracking Id  Update a chunk by tracking_id. This is useful for when you are coordinating with an external system and want to use the tracking_id to identify the chunk.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class UpdateChunkByTrackingIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var updateChunkByTrackingIdData = new UpdateChunkByTrackingIdData(); // UpdateChunkByTrackingIdData | JSON request payload to update a chunk by tracking_id (chunks)

            try
            {
                // Update Chunk By Tracking Id
                apiInstance.UpdateChunkByTrackingId(tRDataset, updateChunkByTrackingIdData);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkApi.UpdateChunkByTrackingId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateChunkByTrackingIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Chunk By Tracking Id
    apiInstance.UpdateChunkByTrackingIdWithHttpInfo(tRDataset, updateChunkByTrackingIdData);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkApi.UpdateChunkByTrackingIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **updateChunkByTrackingIdData** | [**UpdateChunkByTrackingIdData**](UpdateChunkByTrackingIdData.md) | JSON request payload to update a chunk by tracking_id (chunks) |  |

### Return type

void (empty response body)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Confirmation that the chunk has been updated as per your request |  -  |
| **400** | Service error relating to to updating chunk |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

