# trieve_dotnet_client.Model.SearchOverGroupsData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Filters** | [**ChunkFilter**](ChunkFilter.md) |  | [optional] 
**GetCollisions** | **bool?** | Set get_collisions to true to get the collisions for each chunk. This will only apply if environment variable COLLISIONS_ENABLED is set to true. | [optional] 
**GroupSize** | **int?** |  | [optional] 
**HighlightDelimiters** | **List&lt;string&gt;** | Set highlight_delimiters to a list of strings to use as delimiters for highlighting. If not specified, this defaults to [\&quot;?\&quot;, \&quot;,\&quot;, \&quot;.\&quot;, \&quot;!\&quot;]. | [optional] 
**HighlightResults** | **bool?** | Set highlight_results to true to highlight the results. If not specified, this defaults to true. | [optional] 
**Page** | **long?** | Page of chunks to fetch. Each page is 10 chunks. Support for custom page size is coming soon. | [optional] 
**PageSize** | **int?** | Page size is the number of chunks to fetch. This can be used to fetch more than 10 chunks at a time. | [optional] 
**Query** | **string** | Query is the search query. This can be any string. The query will be used to create an embedding vector and/or SPLADE vector which will be used to find the result set. | 
**ScoreThreshold** | **float?** | Set score_threshold to a float to filter out chunks with a score below the threshold. | [optional] 
**SearchType** | **string** | Can be either \&quot;semantic\&quot;, \&quot;fulltext\&quot;, or \&quot;hybrid\&quot;. \&quot;hybrid\&quot; will pull in one page (10 chunks) of both semantic and full-text results then re-rank them using BAAI/bge-reranker-large. \&quot;semantic\&quot; will pull in one page (10 chunks) of the nearest cosine distant vectors. \&quot;fulltext\&quot; will pull in one page (10 chunks) of full-text results based on SPLADE. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

