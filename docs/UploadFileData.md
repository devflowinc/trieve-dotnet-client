# trieve_dotnet_client.Model.UploadFileData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Base64File** | **string** | Base64 encoded file. Convert + to -, / to _, and remove the ending &#x3D; if present. This is the standard base64url encoding. | 
**CreateChunks** | **bool?** | Create chunks is a boolean which determines whether or not to create chunks from the file. If false, you can manually chunk the file and send the chunks to the create_chunk endpoint with the file_id to associate chunks with the file. Meant mostly for advanced users. | [optional] 
**Description** | **string** | Description is an optional convience field so you do not have to remember what the file contains or is about. It will be included on the group resulting from the file which will hold its chunk. | [optional] 
**FileMimeType** | **string** | MIME type of the file being uploaded. | 
**FileName** | **string** | Name of the file being uploaded, including the extension. | 
**Link** | **string** | Link to the file. This can also be any string. This can be used to filter when searching for the file&#39;s resulting chunks. The link value will not affect embedding creation. | [optional] 
**Metadata** | **Object** | Metadata is a JSON object which can be used to filter chunks. This is useful for when you want to filter chunks by arbitrary metadata. Unlike with tag filtering, there is a performance hit for filtering on metadata. Will be passed down to the file&#39;s chunks. | [optional] 
**TagSet** | **List&lt;string&gt;** | Tag set is a comma separated list of tags which will be passed down to the chunks made from the file. Tags are used to filter chunks when searching. HNSW indices are created for each tag such that there is no performance loss when filtering on them. | [optional] 
**TimeStamp** | **string** | Time stamp should be an ISO 8601 combined date and time without timezone. Time_stamp is used for time window filtering and recency-biasing search results. Will be passed down to the file&#39;s chunks. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

