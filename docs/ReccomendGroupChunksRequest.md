# trieve_dotnet_client.Model.ReccomendGroupChunksRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Filters** | [**ChunkFilter**](ChunkFilter.md) |  | [optional] 
**GroupSize** | **int?** | The number of chunks to fetch for each group. This is the number of chunks which will be returned in the response for each group. The default is 10. | [optional] 
**Limit** | **long?** | The number of groups to return. This is the number of groups which will be returned in the response. The default is 10. | [optional] 
**NegativeGroupIds** | **List&lt;Guid&gt;** | The  ids of the groups to be used as negative examples for the recommendation. The groups in this array will be used to filter out similar groups. | [optional] 
**NegativeGroupTrackingIds** | **List&lt;string&gt;** | The  ids of the groups to be used as negative examples for the recommendation. The groups in this array will be used to filter out similar groups. | [optional] 
**PositiveGroupIds** | **List&lt;Guid&gt;** | The  ids of the groups to be used as positive examples for the recommendation. The groups in this array will be used to find similar groups. | [optional] 
**PositiveGroupTrackingIds** | **List&lt;string&gt;** | The  ids of the groups to be used as positive examples for the recommendation. The groups in this array will be used to find similar groups. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

