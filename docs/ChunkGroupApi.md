# trieve_dotnet_client.Api.ChunkGroupApi

All URIs are relative to *http://localhost:8090*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddChunkToGroup**](ChunkGroupApi.md#addchunktogroup) | **POST** /api/chunk_group/chunk/{group_id} | Add Chunk to Group |
| [**AddChunkToGroupByTrackingId**](ChunkGroupApi.md#addchunktogroupbytrackingid) | **POST** /api/chunk_group/tracking_id/{tracking_id} | Add Chunk to Group by Tracking ID |
| [**CreateChunkGroup**](ChunkGroupApi.md#createchunkgroup) | **POST** /api/chunk_group | Create Chunk Group |
| [**DeleteChunkGroup**](ChunkGroupApi.md#deletechunkgroup) | **DELETE** /api/chunk_group/{group_id} | Delete Group |
| [**DeleteGroupByTrackingId**](ChunkGroupApi.md#deletegroupbytrackingid) | **DELETE** /api/chunk_group/tracking_id/{tracking_id} | Delete Group by Tracking ID |
| [**GetChunkGroup**](ChunkGroupApi.md#getchunkgroup) | **GET** /api/chunk_group/{group_id} | Get Group |
| [**GetChunksInGroup**](ChunkGroupApi.md#getchunksingroup) | **GET** /api/chunk_group/{group_id}/{page} | Get Chunks in Group |
| [**GetChunksInGroupByTrackingId**](ChunkGroupApi.md#getchunksingroupbytrackingid) | **GET** /api/chunk_group/tracking_id/{group_tracking_id}/{page} | Get Chunks in Group by Tracking ID |
| [**GetGroupByTrackingId**](ChunkGroupApi.md#getgroupbytrackingid) | **GET** /api/chunk_group/tracking_id/{tracking_id} | Get Group by Tracking ID |
| [**GetGroupsChunkIsIn**](ChunkGroupApi.md#getgroupschunkisin) | **POST** /api/chunk_group/chunks | Get Groups for Chunks |
| [**GetRecommendedGroups**](ChunkGroupApi.md#getrecommendedgroups) | **POST** /api/chunk_group/recommend | Get Recommended Groups |
| [**GetSpecificDatasetChunkGroups**](ChunkGroupApi.md#getspecificdatasetchunkgroups) | **GET** /api/dataset/groups/{dataset_id}/{page} | Get Groups for Dataset |
| [**RemoveChunkFromGroup**](ChunkGroupApi.md#removechunkfromgroup) | **DELETE** /api/chunk_group/chunk/{group_id} | Remove Chunk from Group |
| [**SearchOverGroups**](ChunkGroupApi.md#searchovergroups) | **POST** /api/chunk_group/group_oriented_search | Search Over Groups |
| [**SearchWithinGroup**](ChunkGroupApi.md#searchwithingroup) | **POST** /api/chunk_group/search | Search Within Group |
| [**UpdateChunkGroup**](ChunkGroupApi.md#updatechunkgroup) | **PUT** /api/chunk_group | Update Group |
| [**UpdateGroupByTrackingId**](ChunkGroupApi.md#updategroupbytrackingid) | **PUT** /api/chunk_group/tracking_id/{tracking_id} | Update Group by Tracking ID |

<a id="addchunktogroup"></a>
# **AddChunkToGroup**
> void AddChunkToGroup (string tRDataset, Guid groupId, AddChunkToGroupData addChunkToGroupData)

Add Chunk to Group

Add Chunk to Group  Route to add a chunk to a group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class AddChunkToGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkGroupApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var groupId = "groupId_example";  // Guid | Id of the group to add the chunk to as a bookmark
            var addChunkToGroupData = new AddChunkToGroupData(); // AddChunkToGroupData | JSON request payload to add a chunk to a group (bookmark it)

            try
            {
                // Add Chunk to Group
                apiInstance.AddChunkToGroup(tRDataset, groupId, addChunkToGroupData);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkGroupApi.AddChunkToGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddChunkToGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Chunk to Group
    apiInstance.AddChunkToGroupWithHttpInfo(tRDataset, groupId, addChunkToGroupData);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkGroupApi.AddChunkToGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **groupId** | **Guid** | Id of the group to add the chunk to as a bookmark |  |
| **addChunkToGroupData** | [**AddChunkToGroupData**](AddChunkToGroupData.md) | JSON request payload to add a chunk to a group (bookmark it) |  |

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
| **204** | Confirmation that the chunk was added to the group (bookmark&#39;ed). |  -  |
| **400** | Service error relating to getting the groups that the chunk is in. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addchunktogroupbytrackingid"></a>
# **AddChunkToGroupByTrackingId**
> void AddChunkToGroupByTrackingId (string tRDataset, string trackingId, AddChunkToGroupData addChunkToGroupData)

Add Chunk to Group by Tracking ID

Add Chunk to Group by Tracking ID  Route to add a chunk to a group by tracking id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class AddChunkToGroupByTrackingIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkGroupApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var trackingId = "trackingId_example";  // string | Id of the group to add the chunk to as a bookmark
            var addChunkToGroupData = new AddChunkToGroupData(); // AddChunkToGroupData | JSON request payload to add a chunk to a group (bookmark it)

            try
            {
                // Add Chunk to Group by Tracking ID
                apiInstance.AddChunkToGroupByTrackingId(tRDataset, trackingId, addChunkToGroupData);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkGroupApi.AddChunkToGroupByTrackingId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddChunkToGroupByTrackingIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add Chunk to Group by Tracking ID
    apiInstance.AddChunkToGroupByTrackingIdWithHttpInfo(tRDataset, trackingId, addChunkToGroupData);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkGroupApi.AddChunkToGroupByTrackingIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **trackingId** | **string** | Id of the group to add the chunk to as a bookmark |  |
| **addChunkToGroupData** | [**AddChunkToGroupData**](AddChunkToGroupData.md) | JSON request payload to add a chunk to a group (bookmark it) |  |

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
| **204** | Confirmation that the chunk was added to the group (bookmark&#39;ed). |  -  |
| **400** | Service error relating to getting the groups that the chunk is in. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createchunkgroup"></a>
# **CreateChunkGroup**
> ChunkGroup CreateChunkGroup (string tRDataset, CreateChunkGroupData createChunkGroupData)

Create Chunk Group

Create Chunk Group  Create a new chunk_group. This is a way to group chunks together. If you try to create a chunk_group with the same tracking_id as an existing chunk_group, this operation will fail.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class CreateChunkGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkGroupApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var createChunkGroupData = new CreateChunkGroupData(); // CreateChunkGroupData | JSON request payload to cretea a chunkGroup

            try
            {
                // Create Chunk Group
                ChunkGroup result = apiInstance.CreateChunkGroup(tRDataset, createChunkGroupData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkGroupApi.CreateChunkGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateChunkGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Chunk Group
    ApiResponse<ChunkGroup> response = apiInstance.CreateChunkGroupWithHttpInfo(tRDataset, createChunkGroupData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkGroupApi.CreateChunkGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **createChunkGroupData** | [**CreateChunkGroupData**](CreateChunkGroupData.md) | JSON request payload to cretea a chunkGroup |  |

### Return type

[**ChunkGroup**](ChunkGroup.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Returns the created chunkGroup |  -  |
| **400** | Service error relating to creating the chunkGroup |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletechunkgroup"></a>
# **DeleteChunkGroup**
> void DeleteChunkGroup (string tRDataset, Guid groupId, bool deleteChunks)

Delete Group

Delete Group  This will delete a chunk_group. This will not delete the chunks that are in the group. We will soon support deleting a chunk_group along with its member chunks.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class DeleteChunkGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkGroupApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var groupId = "groupId_example";  // Guid | Id of the group you want to fetch.
            var deleteChunks = true;  // bool | Delete the chunks within the group

            try
            {
                // Delete Group
                apiInstance.DeleteChunkGroup(tRDataset, groupId, deleteChunks);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkGroupApi.DeleteChunkGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteChunkGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Group
    apiInstance.DeleteChunkGroupWithHttpInfo(tRDataset, groupId, deleteChunks);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkGroupApi.DeleteChunkGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **groupId** | **Guid** | Id of the group you want to fetch. |  |
| **deleteChunks** | **bool** | Delete the chunks within the group |  |

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
| **204** | Confirmation that the chunkGroup was deleted |  -  |
| **400** | Service error relating to deleting the chunkGroup |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletegroupbytrackingid"></a>
# **DeleteGroupByTrackingId**
> void DeleteGroupByTrackingId (string tRDataset, string trackingId)

Delete Group by Tracking ID

Delete Group by Tracking ID  Delete a chunk_group with the given tracking id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class DeleteGroupByTrackingIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkGroupApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var trackingId = "trackingId_example";  // string | Tracking id of the chunk_group to delete

            try
            {
                // Delete Group by Tracking ID
                apiInstance.DeleteGroupByTrackingId(tRDataset, trackingId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkGroupApi.DeleteGroupByTrackingId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteGroupByTrackingIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Group by Tracking ID
    apiInstance.DeleteGroupByTrackingIdWithHttpInfo(tRDataset, trackingId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkGroupApi.DeleteGroupByTrackingIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **trackingId** | **string** | Tracking id of the chunk_group to delete |  |

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
| **204** | Confirmation that the chunkGroup was deleted |  -  |
| **400** | Service error relating to deleting the chunkGroup |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getchunkgroup"></a>
# **GetChunkGroup**
> ChunkGroup GetChunkGroup (string tRDataset, Guid groupId)

Get Group

Get Group  Fetch the group with the given id. get_group

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class GetChunkGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkGroupApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var groupId = "groupId_example";  // Guid | Id of the group you want to fetch.

            try
            {
                // Get Group
                ChunkGroup result = apiInstance.GetChunkGroup(tRDataset, groupId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkGroupApi.GetChunkGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChunkGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Group
    ApiResponse<ChunkGroup> response = apiInstance.GetChunkGroupWithHttpInfo(tRDataset, groupId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkGroupApi.GetChunkGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **groupId** | **Guid** | Id of the group you want to fetch. |  |

### Return type

[**ChunkGroup**](ChunkGroup.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | JSON body representing the group with the given tracking id |  -  |
| **400** | Service error relating to getting the group with the given tracking id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getchunksingroup"></a>
# **GetChunksInGroup**
> BookmarkData GetChunksInGroup (string tRDataset, Guid groupId, long? page)

Get Chunks in Group

Get Chunks in Group  Route to get all chunks for a group. The response is paginated, with each page containing 10 chunks. Support for custom page size is coming soon.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class GetChunksInGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkGroupApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var groupId = "groupId_example";  // Guid | Id of the group you want to fetch.
            var page = 789L;  // long? | The page of chunks to get from the group

            try
            {
                // Get Chunks in Group
                BookmarkData result = apiInstance.GetChunksInGroup(tRDataset, groupId, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkGroupApi.GetChunksInGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChunksInGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Chunks in Group
    ApiResponse<BookmarkData> response = apiInstance.GetChunksInGroupWithHttpInfo(tRDataset, groupId, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkGroupApi.GetChunksInGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **groupId** | **Guid** | Id of the group you want to fetch. |  |
| **page** | **long?** | The page of chunks to get from the group |  |

### Return type

[**BookmarkData**](BookmarkData.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Chunks present within the specified group |  -  |
| **400** | Service error relating to getting the groups that the chunk is in |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getchunksingroupbytrackingid"></a>
# **GetChunksInGroupByTrackingId**
> BookmarkData GetChunksInGroupByTrackingId (string tRDataset, string groupTrackingId, long page)

Get Chunks in Group by Tracking ID

Get Chunks in Group by Tracking ID  Route to get all chunks for a group. The response is paginated, with each page containing 10 chunks. Support for custom page size is coming soon.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class GetChunksInGroupByTrackingIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkGroupApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var groupTrackingId = "groupTrackingId_example";  // string | The id of the group to get the chunks from
            var page = 789L;  // long | The page of chunks to get from the group

            try
            {
                // Get Chunks in Group by Tracking ID
                BookmarkData result = apiInstance.GetChunksInGroupByTrackingId(tRDataset, groupTrackingId, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkGroupApi.GetChunksInGroupByTrackingId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetChunksInGroupByTrackingIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Chunks in Group by Tracking ID
    ApiResponse<BookmarkData> response = apiInstance.GetChunksInGroupByTrackingIdWithHttpInfo(tRDataset, groupTrackingId, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkGroupApi.GetChunksInGroupByTrackingIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **groupTrackingId** | **string** | The id of the group to get the chunks from |  |
| **page** | **long** | The page of chunks to get from the group |  |

### Return type

[**BookmarkData**](BookmarkData.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Chunks present within the specified group |  -  |
| **400** | Service error relating to getting the groups that the chunk is in |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getgroupbytrackingid"></a>
# **GetGroupByTrackingId**
> ChunkGroup GetGroupByTrackingId (string tRDataset, string trackingId)

Get Group by Tracking ID

Get Group by Tracking ID  Fetch the group with the given tracking id. get_group_by_tracking_id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class GetGroupByTrackingIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkGroupApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var trackingId = "trackingId_example";  // string | The tracking id of the group to fetch.

            try
            {
                // Get Group by Tracking ID
                ChunkGroup result = apiInstance.GetGroupByTrackingId(tRDataset, trackingId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkGroupApi.GetGroupByTrackingId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupByTrackingIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Group by Tracking ID
    ApiResponse<ChunkGroup> response = apiInstance.GetGroupByTrackingIdWithHttpInfo(tRDataset, trackingId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkGroupApi.GetGroupByTrackingIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **trackingId** | **string** | The tracking id of the group to fetch. |  |

### Return type

[**ChunkGroup**](ChunkGroup.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | JSON body representing the group with the given tracking id |  -  |
| **400** | Service error relating to getting the group with the given tracking id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getgroupschunkisin"></a>
# **GetGroupsChunkIsIn**
> List&lt;BookmarkGroupResult&gt; GetGroupsChunkIsIn (string tRDataset, GetGroupsForChunksData getGroupsForChunksData)

Get Groups for Chunks

Get Groups for Chunks  Route to get the groups that a chunk is in.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class GetGroupsChunkIsInExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkGroupApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var getGroupsForChunksData = new GetGroupsForChunksData(); // GetGroupsForChunksData | JSON request payload to get the groups that a chunk is in

            try
            {
                // Get Groups for Chunks
                List<BookmarkGroupResult> result = apiInstance.GetGroupsChunkIsIn(tRDataset, getGroupsForChunksData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkGroupApi.GetGroupsChunkIsIn: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGroupsChunkIsInWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Groups for Chunks
    ApiResponse<List<BookmarkGroupResult>> response = apiInstance.GetGroupsChunkIsInWithHttpInfo(tRDataset, getGroupsForChunksData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkGroupApi.GetGroupsChunkIsInWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **getGroupsForChunksData** | [**GetGroupsForChunksData**](GetGroupsForChunksData.md) | JSON request payload to get the groups that a chunk is in |  |

### Return type

[**List&lt;BookmarkGroupResult&gt;**](BookmarkGroupResult.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | JSON body representing the groups that the chunk is in |  -  |
| **400** | Service error relating to getting the groups that the chunk is in |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrecommendedgroups"></a>
# **GetRecommendedGroups**
> List&lt;GroupScoreChunkDTO&gt; GetRecommendedGroups (string tRDataset, ReccomendGroupChunksRequest reccomendGroupChunksRequest)

Get Recommended Groups

Get Recommended Groups  Route to get recommended groups. This route will return groups which are similar to the groups in the request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class GetRecommendedGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkGroupApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var reccomendGroupChunksRequest = new ReccomendGroupChunksRequest(); // ReccomendGroupChunksRequest | JSON request payload to get recommendations of chunks similar to the chunks in the request

            try
            {
                // Get Recommended Groups
                List<GroupScoreChunkDTO> result = apiInstance.GetRecommendedGroups(tRDataset, reccomendGroupChunksRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkGroupApi.GetRecommendedGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRecommendedGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Recommended Groups
    ApiResponse<List<GroupScoreChunkDTO>> response = apiInstance.GetRecommendedGroupsWithHttpInfo(tRDataset, reccomendGroupChunksRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkGroupApi.GetRecommendedGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **reccomendGroupChunksRequest** | [**ReccomendGroupChunksRequest**](ReccomendGroupChunksRequest.md) | JSON request payload to get recommendations of chunks similar to the chunks in the request |  |

### Return type

[**List&lt;GroupScoreChunkDTO&gt;**](GroupScoreChunkDTO.md)

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

<a id="getspecificdatasetchunkgroups"></a>
# **GetSpecificDatasetChunkGroups**
> GroupData GetSpecificDatasetChunkGroups (string tRDataset, Guid datasetId, long page)

Get Groups for Dataset

Get Groups for Dataset  Fetch the groups which belong to a dataset specified by its id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class GetSpecificDatasetChunkGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkGroupApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var datasetId = "datasetId_example";  // Guid | The id of the dataset to fetch groups for.
            var page = 789L;  // long | The page of groups to fetch. Each page contains 10 groups. Support for custom page size is coming soon.

            try
            {
                // Get Groups for Dataset
                GroupData result = apiInstance.GetSpecificDatasetChunkGroups(tRDataset, datasetId, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkGroupApi.GetSpecificDatasetChunkGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSpecificDatasetChunkGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Groups for Dataset
    ApiResponse<GroupData> response = apiInstance.GetSpecificDatasetChunkGroupsWithHttpInfo(tRDataset, datasetId, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkGroupApi.GetSpecificDatasetChunkGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **datasetId** | **Guid** | The id of the dataset to fetch groups for. |  |
| **page** | **long** | The page of groups to fetch. Each page contains 10 groups. Support for custom page size is coming soon. |  |

### Return type

[**GroupData**](GroupData.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | JSON body representing the groups created by the given dataset |  -  |
| **400** | Service error relating to getting the groups created by the given dataset |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removechunkfromgroup"></a>
# **RemoveChunkFromGroup**
> void RemoveChunkFromGroup (string tRDataset, Guid groupId, CreateChunkGroupData createChunkGroupData)

Remove Chunk from Group

Remove Chunk from Group  Route to remove a chunk from a group.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class RemoveChunkFromGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkGroupApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var groupId = "groupId_example";  // Guid | Id of the group to remove the bookmark'ed chunk from
            var createChunkGroupData = new CreateChunkGroupData(); // CreateChunkGroupData | JSON request payload to cretea a chunkGroup

            try
            {
                // Remove Chunk from Group
                apiInstance.RemoveChunkFromGroup(tRDataset, groupId, createChunkGroupData);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkGroupApi.RemoveChunkFromGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveChunkFromGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove Chunk from Group
    apiInstance.RemoveChunkFromGroupWithHttpInfo(tRDataset, groupId, createChunkGroupData);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkGroupApi.RemoveChunkFromGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **groupId** | **Guid** | Id of the group to remove the bookmark&#39;ed chunk from |  |
| **createChunkGroupData** | [**CreateChunkGroupData**](CreateChunkGroupData.md) | JSON request payload to cretea a chunkGroup |  |

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
| **204** | Confirmation that the chunk was removed to the group |  -  |
| **400** | Service error relating to removing the chunk from the group |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchovergroups"></a>
# **SearchOverGroups**
> SearchOverGroupsResponseBody SearchOverGroups (SearchOverGroupsData searchOverGroupsData)

Search Over Groups

Search Over Groups  This route allows you to get groups as results instead of chunks. Each group returned will have the matching chunks sorted by similarity within the group. This is useful for when you want to get groups of chunks which are similar to the search query. If choosing hybrid search, the results will be re-ranked using BAAI/bge-reranker-large. Compatible with semantic, fulltext, or hybrid search modes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class SearchOverGroupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            var apiInstance = new ChunkGroupApi(config);
            var searchOverGroupsData = new SearchOverGroupsData(); // SearchOverGroupsData | JSON request payload to semantically search over groups

            try
            {
                // Search Over Groups
                SearchOverGroupsResponseBody result = apiInstance.SearchOverGroups(searchOverGroupsData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkGroupApi.SearchOverGroups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchOverGroupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Over Groups
    ApiResponse<SearchOverGroupsResponseBody> response = apiInstance.SearchOverGroupsWithHttpInfo(searchOverGroupsData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkGroupApi.SearchOverGroupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **searchOverGroupsData** | [**SearchOverGroupsData**](SearchOverGroupsData.md) | JSON request payload to semantically search over groups |  |

### Return type

[**SearchOverGroupsResponseBody**](SearchOverGroupsResponseBody.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Group chunks which are similar to the embedding vector of the search query |  -  |
| **400** | Service error relating to getting the groups that the chunk is in |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="searchwithingroup"></a>
# **SearchWithinGroup**
> SearchGroupsResult SearchWithinGroup (string tRDataset, SearchWithinGroupData searchWithinGroupData)

Search Within Group

Search Within Group  This route allows you to search only within a group. This is useful for when you only want search results to contain chunks which are members of a specific group. If choosing hybrid search, the results will be re-ranked using BAAI/bge-reranker-large.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class SearchWithinGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkGroupApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var searchWithinGroupData = new SearchWithinGroupData(); // SearchWithinGroupData | JSON request payload to semantically search a group

            try
            {
                // Search Within Group
                SearchGroupsResult result = apiInstance.SearchWithinGroup(tRDataset, searchWithinGroupData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkGroupApi.SearchWithinGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SearchWithinGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search Within Group
    ApiResponse<SearchGroupsResult> response = apiInstance.SearchWithinGroupWithHttpInfo(tRDataset, searchWithinGroupData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkGroupApi.SearchWithinGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **searchWithinGroupData** | [**SearchWithinGroupData**](SearchWithinGroupData.md) | JSON request payload to semantically search a group |  |

### Return type

[**SearchGroupsResult**](SearchGroupsResult.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Group chunks which are similar to the embedding vector of the search query |  -  |
| **400** | Service error relating to getting the groups that the chunk is in |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatechunkgroup"></a>
# **UpdateChunkGroup**
> void UpdateChunkGroup (string tRDataset, UpdateChunkGroupData updateChunkGroupData)

Update Group

Update Group  Update a chunk_group. If you try to change the tracking_id to one that already exists, this operation will fail.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class UpdateChunkGroupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkGroupApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var updateChunkGroupData = new UpdateChunkGroupData(); // UpdateChunkGroupData | JSON request payload to update a chunkGroup

            try
            {
                // Update Group
                apiInstance.UpdateChunkGroup(tRDataset, updateChunkGroupData);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkGroupApi.UpdateChunkGroup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateChunkGroupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Group
    apiInstance.UpdateChunkGroupWithHttpInfo(tRDataset, updateChunkGroupData);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkGroupApi.UpdateChunkGroupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **updateChunkGroupData** | [**UpdateChunkGroupData**](UpdateChunkGroupData.md) | JSON request payload to update a chunkGroup |  |

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
| **204** | Confirmation that the chunkGroup was updated |  -  |
| **400** | Service error relating to updating the chunkGroup |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updategroupbytrackingid"></a>
# **UpdateGroupByTrackingId**
> void UpdateGroupByTrackingId (string tRDataset, Guid trackingId, UpdateGroupByTrackingIDData updateGroupByTrackingIDData)

Update Group by Tracking ID

Update Group by Tracking ID  Update a chunk_group with the given tracking id.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class UpdateGroupByTrackingIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ChunkGroupApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var trackingId = "trackingId_example";  // Guid | Tracking id of the chunk_group to update
            var updateGroupByTrackingIDData = new UpdateGroupByTrackingIDData(); // UpdateGroupByTrackingIDData | JSON request payload to update a chunkGroup

            try
            {
                // Update Group by Tracking ID
                apiInstance.UpdateGroupByTrackingId(tRDataset, trackingId, updateGroupByTrackingIDData);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ChunkGroupApi.UpdateGroupByTrackingId: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateGroupByTrackingIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Group by Tracking ID
    apiInstance.UpdateGroupByTrackingIdWithHttpInfo(tRDataset, trackingId, updateGroupByTrackingIDData);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ChunkGroupApi.UpdateGroupByTrackingIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **trackingId** | **Guid** | Tracking id of the chunk_group to update |  |
| **updateGroupByTrackingIDData** | [**UpdateGroupByTrackingIDData**](UpdateGroupByTrackingIDData.md) | JSON request payload to update a chunkGroup |  |

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
| **204** | Confirmation that the chunkGroup was updated |  -  |
| **400** | Service error relating to updating the chunkGroup |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

