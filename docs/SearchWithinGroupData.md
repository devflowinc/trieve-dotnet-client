# trieve_dotnet_client.Model.SearchWithinGroupData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DateBias** | **bool?** | Set date_bias to true to bias search results towards more recent chunks. This will work best in hybrid search mode. | [optional] 
**Filters** | [**ChunkFilter**](ChunkFilter.md) |  | [optional] 
**GroupId** | **Guid?** | Group specifies the group to search within. Results will only consist of chunks which are bookmarks within the specified group. | [optional] 
**GroupTrackingId** | **string** | Group_tracking_id specifies the group to search within by tracking id. Results will only consist of chunks which are bookmarks within the specified group. If both group_id and group_tracking_id are provided, group_id will be used. | [optional] 
**HighlightDelimiters** | **List&lt;string&gt;** | Set highlight_delimiters to a list of strings to use as delimiters for highlighting. If not specified, this defaults to [\&quot;?\&quot;, \&quot;,\&quot;, \&quot;.\&quot;, \&quot;!\&quot;]. | [optional] 
**HighlightResults** | **bool?** | Set highlight_results to true to highlight the results. If not specified, this defaults to true. | [optional] 
**Page** | **long?** | The page of chunks to fetch. Each page is 10 chunks. Support for custom page size is coming soon. | [optional] 
**PageSize** | **long?** | The page size is the number of chunks to fetch. This can be used to fetch more than 10 chunks at a time. | [optional] 
**Query** | **string** | The query is the search query. This can be any string. The query will be used to create an embedding vector and/or SPLADE vector which will be used to find the result set. | 
**ScoreThreshold** | **float?** | Set score_threshold to a float to filter out chunks with a score below the threshold. | [optional] 
**SearchType** | **string** | Search_type can be either \&quot;semantic\&quot;, \&quot;fulltext\&quot;, or \&quot;hybrid\&quot;. \&quot;hybrid\&quot; will pull in one page (10 chunks) of both semantic and full-text results then re-rank them using BAAI/bge-reranker-large. \&quot;semantic\&quot; will pull in one page (10 chunks) of the nearest cosine distant vectors. \&quot;fulltext\&quot; will pull in one page (10 chunks) of full-text results based on SPLADE. | 
**UseWeights** | **bool?** | Set use_weights to true to use the weights of the chunks in the result set in order to sort them. If not specified, this defaults to true. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

