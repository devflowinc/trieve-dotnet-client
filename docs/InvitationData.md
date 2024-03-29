# trieve_dotnet_client.Model.InvitationData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AppUrl** | **string** | The url of the app that the user will be directed to in order to set their password. Usually admin.trieve.ai, but may differ for local dev or self-hosted setups. | 
**Email** | **string** | The email of the user to invite. Must be a valid email as they will be sent an email to register. | 
**OrganizationId** | **Guid** | The id of the organization to invite the user to. | 
**RedirectUri** | **string** | The url that the user will be redirected to after setting their password. | 
**UserRole** | **int** | The role the user will have in the organization. 0 &#x3D; User, 1 &#x3D; Admin, 2 &#x3D; Owner. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

