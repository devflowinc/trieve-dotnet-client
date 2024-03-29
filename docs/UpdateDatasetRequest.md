# trieve_dotnet_client.Model.UpdateDatasetRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ClientConfiguration** | **Object** | The new client configuration of the dataset, can be arbitrary JSON. See docs.trieve.ai for more information. If not provided, the client configuration will not be updated. | [optional] 
**DatasetId** | **Guid** | The id of the dataset you want to update. | 
**DatasetName** | **string** | The new name of the dataset. Must be unique within the organization. If not provided, the name will not be updated. | [optional] 
**ServerConfiguration** | **Object** | The new server configuration of the dataset, can be arbitrary JSON. See docs.trieve.ai for more information. If not provided, the server configuration will not be updated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

