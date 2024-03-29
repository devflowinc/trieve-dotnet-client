# trieve_dotnet_client.Api.FileApi

All URIs are relative to *http://localhost:8090*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteFileHandler**](FileApi.md#deletefilehandler) | **DELETE** /api/file/{file_id} | Delete File |
| [**GetDatasetFilesHandler**](FileApi.md#getdatasetfileshandler) | **GET** /api/dataset/files/{dataset_id}/{page} | Get Files for Dataset |
| [**GetFileHandler**](FileApi.md#getfilehandler) | **GET** /api/file/{file_id} | Get File |
| [**UploadFileHandler**](FileApi.md#uploadfilehandler) | **POST** /api/file | Upload File |

<a id="deletefilehandler"></a>
# **DeleteFileHandler**
> void DeleteFileHandler (string tRDataset, Guid fileId, bool deleteChunks)

Delete File

Delete File  Delete a file from S3 attached to the server based on its id. This will disassociate chunks from the file, but will not delete the chunks. We plan to add support for deleting chunks in a release soon. Auth'ed user must be an admin or owner of the dataset's organization to upload a file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class DeleteFileHandlerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var fileId = "fileId_example";  // Guid | The id of the file to delete
            var deleteChunks = true;  // bool | Whether or not to delete the chunks associated with the file

            try
            {
                // Delete File
                apiInstance.DeleteFileHandler(tRDataset, fileId, deleteChunks);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.DeleteFileHandler: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFileHandlerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete File
    apiInstance.DeleteFileHandlerWithHttpInfo(tRDataset, fileId, deleteChunks);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FileApi.DeleteFileHandlerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **fileId** | **Guid** | The id of the file to delete |  |
| **deleteChunks** | **bool** | Whether or not to delete the chunks associated with the file |  |

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
| **204** | Confirmation that the file has been deleted |  -  |
| **400** | Service error relating to finding or deleting the file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdatasetfileshandler"></a>
# **GetDatasetFilesHandler**
> List&lt;File&gt; GetDatasetFilesHandler (string tRDataset, Guid datasetId, long page)

Get Files for Dataset

Get Files for Dataset  Get all files which belong to a given dataset specified by the dataset_id parameter. 10 files are returned per page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class GetDatasetFilesHandlerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var datasetId = "datasetId_example";  // Guid | The id of the dataset to fetch files for.
            var page = 789L;  // long | The page number of files you wish to fetch. Each page contains at most 10 files.

            try
            {
                // Get Files for Dataset
                List<File> result = apiInstance.GetDatasetFilesHandler(tRDataset, datasetId, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.GetDatasetFilesHandler: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDatasetFilesHandlerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Files for Dataset
    ApiResponse<List<File>> response = apiInstance.GetDatasetFilesHandlerWithHttpInfo(tRDataset, datasetId, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FileApi.GetDatasetFilesHandlerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **datasetId** | **Guid** | The id of the dataset to fetch files for. |  |
| **page** | **long** | The page number of files you wish to fetch. Each page contains at most 10 files. |  |

### Return type

[**List&lt;File&gt;**](File.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | JSON body representing the files in the current dataset |  -  |
| **400** | Service error relating to getting the files in the current datase |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfilehandler"></a>
# **GetFileHandler**
> FileDTO GetFileHandler (string tRDataset, Guid fileId)

Get File

Get File  Download a file from S3 attached to the server based on its id. We plan to add support for getting signed S3 URLs to download from S3 directly in a release soon.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class GetFileHandlerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var fileId = "fileId_example";  // Guid | The id of the file to fetch

            try
            {
                // Get File
                FileDTO result = apiInstance.GetFileHandler(tRDataset, fileId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.GetFileHandler: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFileHandlerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get File
    ApiResponse<FileDTO> response = apiInstance.GetFileHandlerWithHttpInfo(tRDataset, fileId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FileApi.GetFileHandlerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **fileId** | **Guid** | The id of the file to fetch |  |

### Return type

[**FileDTO**](FileDTO.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The signed s3 url corresponding to the file_id requested |  -  |
| **400** | Service error relating to finding the file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="uploadfilehandler"></a>
# **UploadFileHandler**
> UploadFileResult UploadFileHandler (string tRDataset, UploadFileData uploadFileData)

Upload File

Upload File  Upload a file to S3 attached to the server. The file will be converted to HTML with tika and chunked algorithmically, images will be OCR'ed with tesseract. The resulting chunks will be indexed and searchable. Optionally, you can only upload the file and manually create chunks associated to the file after. See docs.trieve.ai and/or contact us for more details and tips. Auth'ed user must be an admin or owner of the dataset's organization to upload a file.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class UploadFileHandlerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new FileApi(config);
            var tRDataset = "tRDataset_example";  // string | The dataset id to use for the request
            var uploadFileData = new UploadFileData(); // UploadFileData | JSON request payload to upload a file

            try
            {
                // Upload File
                UploadFileResult result = apiInstance.UploadFileHandler(tRDataset, uploadFileData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FileApi.UploadFileHandler: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadFileHandlerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Upload File
    ApiResponse<UploadFileResult> response = apiInstance.UploadFileHandlerWithHttpInfo(tRDataset, uploadFileData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FileApi.UploadFileHandlerWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tRDataset** | **string** | The dataset id to use for the request |  |
| **uploadFileData** | [**UploadFileData**](UploadFileData.md) | JSON request payload to upload a file |  |

### Return type

[**UploadFileResult**](UploadFileResult.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Confirmation that the file is uploading |  -  |
| **400** | Service error relating to uploading the file |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

