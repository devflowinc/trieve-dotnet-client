# trieve_dotnet_client.Model.CreateMessageData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HighlightCitations** | **bool?** | Whether or not to highlight the citations in the response. If this is set to true or not included, the citations will be highlighted. If this is set to false, the citations will not be highlighted. Default is true. | [optional] 
**HighlightDelimiters** | **List&lt;string&gt;** | The delimiters to use for highlighting the citations. If this is not included, the default delimiters will be used. Default is &#x60;[\&quot;.\&quot;, \&quot;!\&quot;, \&quot;?\&quot;, \&quot;\\n\&quot;, \&quot;\\t\&quot;, \&quot;,\&quot;]&#x60;. | [optional] 
**Model** | **string** | The model to use for the assistant&#39;s messages. This can be any model from the openrouter model list. If no model is provided, gpt-3.5-turbo will be used. | [optional] 
**NewMessageContent** | **string** | The content of the user message to attach to the topic and then generate an assistant message in response to. | 
**StreamResponse** | **bool?** | Whether or not to stream the response. If this is set to true or not included, the response will be a stream. If this is set to false, the response will be a normal JSON response. Default is true. | [optional] 
**TopicId** | **Guid** | The ID of the topic to attach the message to. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

