# trieve_dotnet_client.Model.FieldCondition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **string** | Field is the name of the field to filter on. The field value will be used to check for an exact substring match on the metadata values for each existing chunk. This is useful for when you want to filter chunks by arbitrary metadata. To access fields inside of the metadata that you provide with the card, prefix the field name with &#x60;metadata.&#x60;. | 
**Match** | [**List&lt;MatchCondition&gt;**](MatchCondition.md) | Match is the value to match on the field. The match value will be used to check for an exact substring match on the metadata values for each existing chunk. This is useful for when you want to filter chunks by arbitrary metadata. | [optional] 
**Range** | [**Range**](Range.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

