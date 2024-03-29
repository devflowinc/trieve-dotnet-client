# trieve_dotnet_client.Model.RecommendChunksRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Filters** | [**ChunkFilter**](ChunkFilter.md) |  | [optional] 
**Limit** | **long?** | The number of chunks to return. This is the number of chunks which will be returned in the response. The default is 10. | [optional] 
**NegativeChunkIds** | **List&lt;Guid&gt;** | The ids of the chunks to be used as negative examples for the recommendation. The chunks in this array will be used to filter out similar chunks. | [optional] 
**NegativeTrackingIds** | **List&lt;string&gt;** | The tracking_ids of the chunks to be used as negative examples for the recommendation. The chunks in this array will be used to filter out similar chunks. | [optional] 
**PositiveChunkIds** | **List&lt;Guid&gt;** | The ids of the chunks to be used as positive examples for the recommendation. The chunks in this array will be used to find similar chunks. | [optional] 
**PositiveTrackingIds** | **List&lt;string&gt;** | The tracking_ids of the chunks to be used as positive examples for the recommendation. The chunks in this array will be used to find similar chunks. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

