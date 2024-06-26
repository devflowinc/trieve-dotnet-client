/*
 * Trieve API
 *
 * Trieve OpenAPI Specification. This document describes all of the operations available through the Trieve API.
 *
 * The version of the OpenAPI document: 0.5.0
 * Contact: developers@trieve.ai
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = trieve_dotnet_client.Client.OpenAPIDateConverter;

namespace trieve_dotnet_client.Model
{
    /// <summary>
    /// RegenerateMessageData
    /// </summary>
    [DataContract(Name = "RegenerateMessageData")]
    public partial class RegenerateMessageData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegenerateMessageData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RegenerateMessageData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RegenerateMessageData" /> class.
        /// </summary>
        /// <param name="highlightCitations">Whether or not to highlight the citations in the response. If this is set to true or not included, the citations will be highlighted. If this is set to false, the citations will not be highlighted. Default is true..</param>
        /// <param name="highlightDelimiters">The delimiters to use for highlighting the citations. If this is not included, the default delimiters will be used. Default is &#x60;[\&quot;.\&quot;, \&quot;!\&quot;, \&quot;?\&quot;, \&quot;\\n\&quot;, \&quot;\\t\&quot;, \&quot;,\&quot;]&#x60;..</param>
        /// <param name="model">The model to use for the assistant generative inferences. This can be any model from the openrouter model list. If no model is provided, the gpt-3.5-turbo will be used.~.</param>
        /// <param name="streamResponse">Whether or not to stream the response. If this is set to true or not included, the response will be a stream. If this is set to false, the response will be a normal JSON response. Default is true..</param>
        /// <param name="topicId">The id of the topic to regenerate the last message for. (required).</param>
        public RegenerateMessageData(bool? highlightCitations = default(bool?), List<string> highlightDelimiters = default(List<string>), string model = default(string), bool? streamResponse = default(bool?), Guid topicId = default(Guid))
        {
            this.TopicId = topicId;
            this.HighlightCitations = highlightCitations;
            this.HighlightDelimiters = highlightDelimiters;
            this.Model = model;
            this.StreamResponse = streamResponse;
        }

        /// <summary>
        /// Whether or not to highlight the citations in the response. If this is set to true or not included, the citations will be highlighted. If this is set to false, the citations will not be highlighted. Default is true.
        /// </summary>
        /// <value>Whether or not to highlight the citations in the response. If this is set to true or not included, the citations will be highlighted. If this is set to false, the citations will not be highlighted. Default is true.</value>
        [DataMember(Name = "highlight_citations", EmitDefaultValue = true)]
        public bool? HighlightCitations { get; set; }

        /// <summary>
        /// The delimiters to use for highlighting the citations. If this is not included, the default delimiters will be used. Default is &#x60;[\&quot;.\&quot;, \&quot;!\&quot;, \&quot;?\&quot;, \&quot;\\n\&quot;, \&quot;\\t\&quot;, \&quot;,\&quot;]&#x60;.
        /// </summary>
        /// <value>The delimiters to use for highlighting the citations. If this is not included, the default delimiters will be used. Default is &#x60;[\&quot;.\&quot;, \&quot;!\&quot;, \&quot;?\&quot;, \&quot;\\n\&quot;, \&quot;\\t\&quot;, \&quot;,\&quot;]&#x60;.</value>
        [DataMember(Name = "highlight_delimiters", EmitDefaultValue = true)]
        public List<string> HighlightDelimiters { get; set; }

        /// <summary>
        /// The model to use for the assistant generative inferences. This can be any model from the openrouter model list. If no model is provided, the gpt-3.5-turbo will be used.~
        /// </summary>
        /// <value>The model to use for the assistant generative inferences. This can be any model from the openrouter model list. If no model is provided, the gpt-3.5-turbo will be used.~</value>
        [DataMember(Name = "model", EmitDefaultValue = true)]
        public string Model { get; set; }

        /// <summary>
        /// Whether or not to stream the response. If this is set to true or not included, the response will be a stream. If this is set to false, the response will be a normal JSON response. Default is true.
        /// </summary>
        /// <value>Whether or not to stream the response. If this is set to true or not included, the response will be a stream. If this is set to false, the response will be a normal JSON response. Default is true.</value>
        [DataMember(Name = "stream_response", EmitDefaultValue = true)]
        public bool? StreamResponse { get; set; }

        /// <summary>
        /// The id of the topic to regenerate the last message for.
        /// </summary>
        /// <value>The id of the topic to regenerate the last message for.</value>
        [DataMember(Name = "topic_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid TopicId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RegenerateMessageData {\n");
            sb.Append("  HighlightCitations: ").Append(HighlightCitations).Append("\n");
            sb.Append("  HighlightDelimiters: ").Append(HighlightDelimiters).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  StreamResponse: ").Append(StreamResponse).Append("\n");
            sb.Append("  TopicId: ").Append(TopicId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
