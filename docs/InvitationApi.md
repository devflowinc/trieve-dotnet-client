# trieve_dotnet_client.Api.InvitationApi

All URIs are relative to *http://localhost:8090*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PostInvitation**](InvitationApi.md#postinvitation) | **POST** /api/invitation | Send Invitation |

<a id="postinvitation"></a>
# **PostInvitation**
> void PostInvitation (string tROrganization, InvitationData invitationData)

Send Invitation

Send Invitation  Invitations act as a way to invite users to join an organization. After a user is invited, they will automatically be added to the organization with the role specified in the invitation once they set their.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class PostInvitationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new InvitationApi(config);
            var tROrganization = "tROrganization_example";  // string | The organization id to use for the request
            var invitationData = new InvitationData(); // InvitationData | JSON request payload to send an invitation

            try
            {
                // Send Invitation
                apiInstance.PostInvitation(tROrganization, invitationData);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InvitationApi.PostInvitation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PostInvitationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send Invitation
    apiInstance.PostInvitationWithHttpInfo(tROrganization, invitationData);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InvitationApi.PostInvitationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tROrganization** | **string** | The organization id to use for the request |  |
| **invitationData** | [**InvitationData**](InvitationData.md) | JSON request payload to send an invitation |  |

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
| **204** | Ok response. Indicates that invitation email was sent correctly. |  -  |
| **400** | Invalid email or some other error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

