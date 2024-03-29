# trieve_dotnet_client.Api.TopicApi

All URIs are relative to *http://localhost:8090*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTopic**](TopicApi.md#createtopic) | **POST** /api/topic | Create Topic |
| [**DeleteTopic**](TopicApi.md#deletetopic) | **DELETE** /api/topic | Delete Topic |
| [**GetAllTopicsForUser**](TopicApi.md#getalltopicsforuser) | **GET** /api/topic/user/{user_id} | Get All Topics for User |
| [**UpdateTopic**](TopicApi.md#updatetopic) | **PUT** /api/topic | Update Topic |

<a id="createtopic"></a>
# **CreateTopic**
> Topic CreateTopic (string tRDataset, CreateTopicData createTopicData)

Create Topic

Create Topic  Create a new chat topic. Topics are attached to a user and act as a coordinator for memory of gen-AI chat sessions. We are considering refactoring this resource of the API soon.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class CreateTopicExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TopicApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var createTopicData = new CreateTopicData(); // CreateTopicData | JSON request payload to create chat topic

            try
            {
                // Create Topic
                Topic result = apiInstance.CreateTopic(tRDataset, createTopicData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TopicApi.CreateTopic: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTopicWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Topic
    ApiResponse<Topic> response = apiInstance.CreateTopicWithHttpInfo(tRDataset, createTopicData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TopicApi.CreateTopicWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **createTopicData** | [**CreateTopicData**](CreateTopicData.md) | JSON request payload to create chat topic |  |

### Return type

[**Topic**](Topic.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The JSON response payload containing the created topic |  -  |
| **400** | Topic name empty or a service error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetopic"></a>
# **DeleteTopic**
> void DeleteTopic (string tRDataset, DeleteTopicData deleteTopicData)

Delete Topic

Delete Topic  Delete an existing chat topic. When a topic is deleted, all associated chat messages are also deleted.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class DeleteTopicExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TopicApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var deleteTopicData = new DeleteTopicData(); // DeleteTopicData | JSON request payload to delete a chat topic

            try
            {
                // Delete Topic
                apiInstance.DeleteTopic(tRDataset, deleteTopicData);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TopicApi.DeleteTopic: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTopicWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Topic
    apiInstance.DeleteTopicWithHttpInfo(tRDataset, deleteTopicData);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TopicApi.DeleteTopicWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **deleteTopicData** | [**DeleteTopicData**](DeleteTopicData.md) | JSON request payload to delete a chat topic |  |

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
| **204** | Confirmation that the topic was deleted |  -  |
| **400** | Service error relating to topic deletion |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getalltopicsforuser"></a>
# **GetAllTopicsForUser**
> List&lt;Topic&gt; GetAllTopicsForUser (Guid userId, string tRDataset)

Get All Topics for User

Get All Topics for User  Get all topics belonging to a the auth'ed user. Soon, we plan to allow specification of the user for this route and include pagination.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class GetAllTopicsForUserExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TopicApi(config);
            var userId = "userId_example";  // Guid | The id of the user to get topics for
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request

            try
            {
                // Get All Topics for User
                List<Topic> result = apiInstance.GetAllTopicsForUser(userId, tRDataset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TopicApi.GetAllTopicsForUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllTopicsForUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get All Topics for User
    ApiResponse<List<Topic>> response = apiInstance.GetAllTopicsForUserWithHttpInfo(userId, tRDataset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TopicApi.GetAllTopicsForUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **userId** | **Guid** | The id of the user to get topics for |  |
| **tRDataset** | **string** | The dataset id to use for the request |  |

### Return type

[**List&lt;Topic&gt;**](Topic.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | All topics belonging to a given user |  -  |
| **400** | Service error relating to topic get |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetopic"></a>
# **UpdateTopic**
> void UpdateTopic (string tRDataset, UpdateTopicData updateTopicData)

Update Topic

Update Topic  Update an existing chat topic. Currently, only the name of the topic can be updated.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class UpdateTopicExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TopicApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var updateTopicData = new UpdateTopicData(); // UpdateTopicData | JSON request payload to update a chat topic

            try
            {
                // Update Topic
                apiInstance.UpdateTopic(tRDataset, updateTopicData);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TopicApi.UpdateTopic: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTopicWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Topic
    apiInstance.UpdateTopicWithHttpInfo(tRDataset, updateTopicData);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TopicApi.UpdateTopicWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **updateTopicData** | [**UpdateTopicData**](UpdateTopicData.md) | JSON request payload to update a chat topic |  |

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
| **204** | Confirmation that the topic was updated |  -  |
| **400** | Service error relating to topic update |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

