# trieve_dotnet_client.Api.DatasetApi

All URIs are relative to *http://localhost:8090*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateDataset**](DatasetApi.md#createdataset) | **POST** /api/dataset | Create dataset |
| [**DeleteDataset**](DatasetApi.md#deletedataset) | **DELETE** /api/dataset | Delete Dataset |
| [**GetClientDatasetConfig**](DatasetApi.md#getclientdatasetconfig) | **GET** /api/dataset/envs | Get Client Configuration |
| [**GetDataset**](DatasetApi.md#getdataset) | **GET** /api/dataset/{dataset_id} | Get Dataset |
| [**GetDatasetsFromOrganization**](DatasetApi.md#getdatasetsfromorganization) | **GET** /api/dataset/organization/{organization_id} | Get Datasets from Organization |
| [**UpdateDataset**](DatasetApi.md#updatedataset) | **PUT** /api/dataset | Update Dataset |

<a id="createdataset"></a>
# **CreateDataset**
> Dataset CreateDataset (string tROrganization, CreateDatasetRequest createDatasetRequest)

Create dataset

Create dataset  Create a new dataset. The auth'ed user must be an owner of the organization to create a dataset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class CreateDatasetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DatasetApi(config);
            var tROrganization = "tROrganization_example";  // string | The organization id to use for the request
            var createDatasetRequest = new CreateDatasetRequest(); // CreateDatasetRequest | JSON request payload to create a new dataset

            try
            {
                // Create dataset
                Dataset result = apiInstance.CreateDataset(tROrganization, createDatasetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.CreateDataset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDatasetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create dataset
    ApiResponse<Dataset> response = apiInstance.CreateDatasetWithHttpInfo(tROrganization, createDatasetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.CreateDatasetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tROrganization** | **string** | The organization id to use for the request |  |
| **createDatasetRequest** | [**CreateDatasetRequest**](CreateDatasetRequest.md) | JSON request payload to create a new dataset |  |

### Return type

[**Dataset**](Dataset.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dataset created successfully |  -  |
| **400** | Service error relating to creating the dataset |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletedataset"></a>
# **DeleteDataset**
> void DeleteDataset (string tROrganization, DeleteDatasetRequest deleteDatasetRequest)

Delete Dataset

Delete Dataset  Delete a dataset. The auth'ed user must be an owner of the organization to delete a dataset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class DeleteDatasetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DatasetApi(config);
            var tROrganization = "tROrganization_example";  // string | The organization id to use for the request
            var deleteDatasetRequest = new DeleteDatasetRequest(); // DeleteDatasetRequest | JSON request payload to delete a dataset

            try
            {
                // Delete Dataset
                apiInstance.DeleteDataset(tROrganization, deleteDatasetRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.DeleteDataset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDatasetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Dataset
    apiInstance.DeleteDatasetWithHttpInfo(tROrganization, deleteDatasetRequest);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.DeleteDatasetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tROrganization** | **string** | The organization id to use for the request |  |
| **deleteDatasetRequest** | [**DeleteDatasetRequest**](DeleteDatasetRequest.md) | JSON request payload to delete a dataset |  |

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
| **204** | Dataset deleted successfully |  -  |
| **400** | Service error relating to deleting the dataset |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getclientdatasetconfig"></a>
# **GetClientDatasetConfig**
> ClientDatasetConfiguration GetClientDatasetConfig (string tRDataset)

Get Client Configuration

Get Client Configuration  Get the client configuration for a dataset. Will use the TR-D

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class GetClientDatasetConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DatasetApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request

            try
            {
                // Get Client Configuration
                ClientDatasetConfiguration result = apiInstance.GetClientDatasetConfig(tRDataset);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.GetClientDatasetConfig: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetClientDatasetConfigWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Client Configuration
    ApiResponse<ClientDatasetConfiguration> response = apiInstance.GetClientDatasetConfigWithHttpInfo(tRDataset);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.GetClientDatasetConfigWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |

### Return type

[**ClientDatasetConfiguration**](ClientDatasetConfiguration.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dataset environment variables |  -  |
| **400** | Service error relating to retrieving the dataset. Typically this only happens when your auth credentials are invalid. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdataset"></a>
# **GetDataset**
> Dataset GetDataset (string tROrganization, string tRDataset, Guid datasetId)

Get Dataset

Get Dataset  Get a dataset by id. The auth'ed user must be an admin or owner of the organization to get a dataset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class GetDatasetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DatasetApi(config);
            var tROrganization = "tROrganization_example";  // string | The organization id to use for the request
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var datasetId = "datasetId_example";  // Guid | The id of the dataset you want to retrieve.

            try
            {
                // Get Dataset
                Dataset result = apiInstance.GetDataset(tROrganization, tRDataset, datasetId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.GetDataset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDatasetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Dataset
    ApiResponse<Dataset> response = apiInstance.GetDatasetWithHttpInfo(tROrganization, tRDataset, datasetId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.GetDatasetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tROrganization** | **string** | The organization id to use for the request |  |
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **datasetId** | **Guid** | The id of the dataset you want to retrieve. |  |

### Return type

[**Dataset**](Dataset.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dataset retrieved successfully |  -  |
| **400** | Service error relating to retrieving the dataset |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdatasetsfromorganization"></a>
# **GetDatasetsFromOrganization**
> List&lt;DatasetAndUsage&gt; GetDatasetsFromOrganization (string tROrganization, Guid organizationId)

Get Datasets from Organization

Get Datasets from Organization  Get all datasets for an organization. The auth'ed user must be an admin or owner of the organization to get its datasets.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class GetDatasetsFromOrganizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DatasetApi(config);
            var tROrganization = "tROrganization_example";  // string | The organization id to use for the request
            var organizationId = "organizationId_example";  // Guid | id of the organization you want to retrieve datasets for

            try
            {
                // Get Datasets from Organization
                List<DatasetAndUsage> result = apiInstance.GetDatasetsFromOrganization(tROrganization, organizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.GetDatasetsFromOrganization: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDatasetsFromOrganizationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Datasets from Organization
    ApiResponse<List<DatasetAndUsage>> response = apiInstance.GetDatasetsFromOrganizationWithHttpInfo(tROrganization, organizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.GetDatasetsFromOrganizationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tROrganization** | **string** | The organization id to use for the request |  |
| **organizationId** | **Guid** | id of the organization you want to retrieve datasets for |  |

### Return type

[**List&lt;DatasetAndUsage&gt;**](DatasetAndUsage.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Datasets retrieved successfully |  -  |
| **400** | Service error relating to retrieving the dataset |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatedataset"></a>
# **UpdateDataset**
> Dataset UpdateDataset (string tROrganization, UpdateDatasetRequest updateDatasetRequest)

Update Dataset

Update Dataset  Update a dataset. The auth'ed user must be an owner of the organization to update a dataset.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class UpdateDatasetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new DatasetApi(config);
            var tROrganization = "tROrganization_example";  // string | The organization id to use for the request
            var updateDatasetRequest = new UpdateDatasetRequest(); // UpdateDatasetRequest | JSON request payload to update a dataset

            try
            {
                // Update Dataset
                Dataset result = apiInstance.UpdateDataset(tROrganization, updateDatasetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DatasetApi.UpdateDataset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDatasetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Dataset
    ApiResponse<Dataset> response = apiInstance.UpdateDatasetWithHttpInfo(tROrganization, updateDatasetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DatasetApi.UpdateDatasetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tROrganization** | **string** | The organization id to use for the request |  |
| **updateDatasetRequest** | [**UpdateDatasetRequest**](UpdateDatasetRequest.md) | JSON request payload to update a dataset |  |

### Return type

[**Dataset**](Dataset.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Dataset updated successfully |  -  |
| **400** | Service error relating to updating the dataset |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

