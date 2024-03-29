# trieve_dotnet_client.Api.HealthApi

All URIs are relative to *http://localhost:8090*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HealthCheck**](HealthApi.md#healthcheck) | **GET** /api/health | Health Check |

<a id="healthcheck"></a>
# **HealthCheck**
> void HealthCheck ()

Health Check

Health Check  Confirmation that the service is healthy and can make embedding vectors

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class HealthCheckExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            var apiInstance = new HealthApi(config);

            try
            {
                // Health Check
                apiInstance.HealthCheck();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling HealthApi.HealthCheck: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the HealthCheckWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Health Check
    apiInstance.HealthCheckWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling HealthApi.HealthCheckWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Confirmation that the service is healthy and can make embedding vectors |  -  |
| **400** | Service error relating to making an embedding or overall service health |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

