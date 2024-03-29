# trieve_dotnet_client.Api.OrganizationApi

All URIs are relative to *http://localhost:8090*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateOrganization**](OrganizationApi.md#createorganization) | **POST** /api/organization | Create Organization |
| [**DeleteOrganizationById**](OrganizationApi.md#deleteorganizationbyid) | **DELETE** /api/organization/{organization_id} | Delete Organization |
| [**GetOrganizationById**](OrganizationApi.md#getorganizationbyid) | **GET** /api/organization/{organization_id} | Get Organization |
| [**GetOrganizationUsage**](OrganizationApi.md#getorganizationusage) | **GET** /api/organization/usage/{organization_id} | Get Organization Usage |
| [**GetOrganizationUsers**](OrganizationApi.md#getorganizationusers) | **GET** /api/organization/users/{organization_id} | Get Organization Users |
| [**UpdateOrganization**](OrganizationApi.md#updateorganization) | **PUT** /api/organization | Update Organization |

<a id="createorganization"></a>
# **CreateOrganization**
> Organization CreateOrganization (CreateOrganizationData createOrganizationData)

Create Organization

Create Organization  Create a new organization. The auth'ed user who creates the organization will be the default owner of the organization.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class CreateOrganizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationApi(config);
            var createOrganizationData = new CreateOrganizationData(); // CreateOrganizationData | The organization data that you want to create

            try
            {
                // Create Organization
                Organization result = apiInstance.CreateOrganization(createOrganizationData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationApi.CreateOrganization: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateOrganizationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Organization
    ApiResponse<Organization> response = apiInstance.CreateOrganizationWithHttpInfo(createOrganizationData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationApi.CreateOrganizationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createOrganizationData** | [**CreateOrganizationData**](CreateOrganizationData.md) | The organization data that you want to create |  |

### Return type

[**Organization**](Organization.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Created organization object |  -  |
| **400** | Service error relating to creating the organization |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteorganizationbyid"></a>
# **DeleteOrganizationById**
> Organization DeleteOrganizationById (string tROrganization, Guid organizationId)

Delete Organization

Delete Organization  Delete an organization by its id. The auth'ed user must be an owner of the organization to delete it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class DeleteOrganizationByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationApi(config);
            var tROrganization = "tROrganization_example";  // string | The organization id to use for the request
            var organizationId = "organizationId_example";  // Guid | The id of the organization you want to fetch.

            try
            {
                // Delete Organization
                Organization result = apiInstance.DeleteOrganizationById(tROrganization, organizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationApi.DeleteOrganizationById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteOrganizationByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Organization
    ApiResponse<Organization> response = apiInstance.DeleteOrganizationByIdWithHttpInfo(tROrganization, organizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationApi.DeleteOrganizationByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tROrganization** | **string** | The organization id to use for the request |  |
| **organizationId** | **Guid** | The id of the organization you want to fetch. |  |

### Return type

[**Organization**](Organization.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Confirmation that the organization was deleted |  -  |
| **400** | Service error relating to deleting the organization by id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getorganizationbyid"></a>
# **GetOrganizationById**
> Organization GetOrganizationById (string tROrganization, Guid organizationId)

Get Organization

Get Organization  Fetch the details of an organization by its id. The auth'ed user must be an admin or owner of the organization to fetch it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class GetOrganizationByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationApi(config);
            var tROrganization = "tROrganization_example";  // string | The organization id to use for the request
            var organizationId = "organizationId_example";  // Guid | The id of the organization you want to fetch.

            try
            {
                // Get Organization
                Organization result = apiInstance.GetOrganizationById(tROrganization, organizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetOrganizationById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrganizationByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Organization
    ApiResponse<Organization> response = apiInstance.GetOrganizationByIdWithHttpInfo(tROrganization, organizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationApi.GetOrganizationByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tROrganization** | **string** | The organization id to use for the request |  |
| **organizationId** | **Guid** | The id of the organization you want to fetch. |  |

### Return type

[**Organization**](Organization.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Organization with the id that was requested |  -  |
| **400** | Service error relating to finding the organization by id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getorganizationusage"></a>
# **GetOrganizationUsage**
> OrganizationUsageCount GetOrganizationUsage (string tROrganization, Guid organizationId)

Get Organization Usage

Get Organization Usage  Fetch the current usage specification of an organization by its id. The auth'ed user must be an admin or owner of the organization to fetch it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class GetOrganizationUsageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationApi(config);
            var tROrganization = "tROrganization_example";  // string | The organization id to use for the request
            var organizationId = "organizationId_example";  // Guid | The id of the organization you want to fetch the usage of.

            try
            {
                // Get Organization Usage
                OrganizationUsageCount result = apiInstance.GetOrganizationUsage(tROrganization, organizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetOrganizationUsage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrganizationUsageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Organization Usage
    ApiResponse<OrganizationUsageCount> response = apiInstance.GetOrganizationUsageWithHttpInfo(tROrganization, organizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationApi.GetOrganizationUsageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tROrganization** | **string** | The organization id to use for the request |  |
| **organizationId** | **Guid** | The id of the organization you want to fetch the usage of. |  |

### Return type

[**OrganizationUsageCount**](OrganizationUsageCount.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The current usage of the specified organization |  -  |
| **400** | Service error relating to finding the organization&#39;s usage by id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getorganizationusers"></a>
# **GetOrganizationUsers**
> List&lt;SlimUser&gt; GetOrganizationUsers (string tROrganization, Guid organizationId)

Get Organization Users

Get Organization Users  Fetch the users of an organization by its id. The auth'ed user must be an admin or owner of the organization to fetch it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class GetOrganizationUsersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationApi(config);
            var tROrganization = "tROrganization_example";  // string | The organization id to use for the request
            var organizationId = "organizationId_example";  // Guid | The id of the organization you want to fetch the users of.

            try
            {
                // Get Organization Users
                List<SlimUser> result = apiInstance.GetOrganizationUsers(tROrganization, organizationId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationApi.GetOrganizationUsers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetOrganizationUsersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Organization Users
    ApiResponse<List<SlimUser>> response = apiInstance.GetOrganizationUsersWithHttpInfo(tROrganization, organizationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationApi.GetOrganizationUsersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tROrganization** | **string** | The organization id to use for the request |  |
| **organizationId** | **Guid** | The id of the organization you want to fetch the users of. |  |

### Return type

[**List&lt;SlimUser&gt;**](SlimUser.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Array of users who belong to the specified by organization |  -  |
| **400** | Service error relating to finding the organization&#39;s users by id |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateorganization"></a>
# **UpdateOrganization**
> Organization UpdateOrganization (string tROrganization, UpdateOrganizationData updateOrganizationData)

Update Organization

Update Organization  Update an organization. Only the owner of the organization can update it.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class UpdateOrganizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OrganizationApi(config);
            var tROrganization = "tROrganization_example";  // string | The organization id to use for the request
            var updateOrganizationData = new UpdateOrganizationData(); // UpdateOrganizationData | The organization data that you want to update

            try
            {
                // Update Organization
                Organization result = apiInstance.UpdateOrganization(tROrganization, updateOrganizationData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrganizationApi.UpdateOrganization: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateOrganizationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Organization
    ApiResponse<Organization> response = apiInstance.UpdateOrganizationWithHttpInfo(tROrganization, updateOrganizationData);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling OrganizationApi.UpdateOrganizationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tROrganization** | **string** | The organization id to use for the request |  |
| **updateOrganizationData** | [**UpdateOrganizationData**](UpdateOrganizationData.md) | The organization data that you want to update |  |

### Return type

[**Organization**](Organization.md)

### Authorization

[ApiKey](../README.md#ApiKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated organization object |  -  |
| **400** | Service error relating to updating the organization |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

