# trieve_dotnet_client.Api.StripeApi

All URIs are relative to *http://localhost:8090*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelSubscription**](StripeApi.md#cancelsubscription) | **DELETE** /api/stripe/subscription/{subscription_id} | Cancel Subscription |
| [**DirectToPaymentLink**](StripeApi.md#directtopaymentlink) | **GET** /api/stripe/payment_link/{plan_id}/{organization_id} | Checkout |
| [**GetAllPlans**](StripeApi.md#getallplans) | **GET** /api/stripe/plans | Get All Plans |
| [**UpdateSubscriptionPlan**](StripeApi.md#updatesubscriptionplan) | **PATCH** /api/stripe/subscription_plan/{subscription_id}/{plan_id} | Update Subscription Plan |

<a id="cancelsubscription"></a>
# **CancelSubscription**
> void CancelSubscription (string tROrganization, Guid subscriptionId)

Cancel Subscription

Cancel Subscription  Cancel a subscription by its id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class CancelSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StripeApi(config);
            var tROrganization = "tROrganization_example";  // string | The organization id to use for the request
            var subscriptionId = "subscriptionId_example";  // Guid | id of the subscription you want to cancel

            try
            {
                // Cancel Subscription
                apiInstance.CancelSubscription(tROrganization, subscriptionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StripeApi.CancelSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel Subscription
    apiInstance.CancelSubscriptionWithHttpInfo(tROrganization, subscriptionId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StripeApi.CancelSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tROrganization** | **string** | The organization id to use for the request |  |
| **subscriptionId** | **Guid** | id of the subscription you want to cancel |  |

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
| **200** | Confirmation that the subscription was cancelled |  -  |
| **400** | Service error relating to creating a URL for a stripe checkout page |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="directtopaymentlink"></a>
# **DirectToPaymentLink**
> void DirectToPaymentLink (Guid planId, Guid organizationId)

Checkout

Checkout  Get a direct link to the stripe checkout page for the plan and organization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class DirectToPaymentLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            var apiInstance = new StripeApi(config);
            var planId = "planId_example";  // Guid | id of the plan you want to subscribe to
            var organizationId = "organizationId_example";  // Guid | id of the organization you want to subscribe to the plan

            try
            {
                // Checkout
                apiInstance.DirectToPaymentLink(planId, organizationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StripeApi.DirectToPaymentLink: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DirectToPaymentLinkWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Checkout
    apiInstance.DirectToPaymentLinkWithHttpInfo(planId, organizationId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StripeApi.DirectToPaymentLinkWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **planId** | **Guid** | id of the plan you want to subscribe to |  |
| **organizationId** | **Guid** | id of the organization you want to subscribe to the plan |  |

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
| **303** | SeeOther response redirecting user to stripe checkout page |  -  |
| **400** | Service error relating to creating a URL for a stripe checkout page |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getallplans"></a>
# **GetAllPlans**
> List&lt;StripePlan&gt; GetAllPlans ()

Get All Plans

Get All Plans  Get a list of all plans

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class GetAllPlansExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            var apiInstance = new StripeApi(config);

            try
            {
                // Get All Plans
                List<StripePlan> result = apiInstance.GetAllPlans();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StripeApi.GetAllPlans: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllPlansWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get All Plans
    ApiResponse<List<StripePlan>> response = apiInstance.GetAllPlansWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StripeApi.GetAllPlansWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;StripePlan&gt;**](StripePlan.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of all plans |  -  |
| **400** | Service error relating to getting all plans |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatesubscriptionplan"></a>
# **UpdateSubscriptionPlan**
> void UpdateSubscriptionPlan (string tROrganization, Guid subscriptionId, Guid planId)

Update Subscription Plan

Update Subscription Plan  Update a subscription to a new plan

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using trieve_dotnet_client.Api;
using trieve_dotnet_client.Client;
using trieve_dotnet_client.Model;

namespace Example
{
    public class UpdateSubscriptionPlanExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost:8090";
            // Configure API key authorization: ApiKey
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new StripeApi(config);
            var tROrganization = "tROrganization_example";  // string | The organization id to use for the request
            var subscriptionId = "subscriptionId_example";  // Guid | id of the subscription you want to update
            var planId = "planId_example";  // Guid | id of the plan you want to subscribe to

            try
            {
                // Update Subscription Plan
                apiInstance.UpdateSubscriptionPlan(tROrganization, subscriptionId, planId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StripeApi.UpdateSubscriptionPlan: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateSubscriptionPlanWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Subscription Plan
    apiInstance.UpdateSubscriptionPlanWithHttpInfo(tROrganization, subscriptionId, planId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StripeApi.UpdateSubscriptionPlanWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **tROrganization** | **string** | The organization id to use for the request |  |
| **subscriptionId** | **Guid** | id of the subscription you want to update |  |
| **planId** | **Guid** | id of the plan you want to subscribe to |  |

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
| **200** | Confirmation that the subscription was updated to the new plan |  -  |
| **400** | Service error relating to updating the subscription to the new plan |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

