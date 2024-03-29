# trieve_dotnet_client.Model.ChunkFilter

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Must** | [**List&lt;FieldCondition&gt;**](FieldCondition.md) | All of these field conditions have to match for the chunk to be included in the result set. | [optional] 
**MustNot** | [**List&lt;FieldCondition&gt;**](FieldCondition.md) | None of these field conditions can match for the chunk to be included in the result set. | [optional] 
**Should** | [**List&lt;FieldCondition&gt;**](FieldCondition.md) | Only one of these field conditions has to match for the chunk to be included in the result set. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

