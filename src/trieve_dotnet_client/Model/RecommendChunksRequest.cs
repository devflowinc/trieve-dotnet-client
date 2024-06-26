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
    /// RecommendChunksRequest
    /// </summary>
    [DataContract(Name = "RecommendChunksRequest")]
    public partial class RecommendChunksRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecommendChunksRequest" /> class.
        /// </summary>
        /// <param name="filters">filters.</param>
        /// <param name="limit">The number of chunks to return. This is the number of chunks which will be returned in the response. The default is 10..</param>
        /// <param name="negativeChunkIds">The ids of the chunks to be used as negative examples for the recommendation. The chunks in this array will be used to filter out similar chunks..</param>
        /// <param name="negativeTrackingIds">The tracking_ids of the chunks to be used as negative examples for the recommendation. The chunks in this array will be used to filter out similar chunks..</param>
        /// <param name="positiveChunkIds">The ids of the chunks to be used as positive examples for the recommendation. The chunks in this array will be used to find similar chunks..</param>
        /// <param name="positiveTrackingIds">The tracking_ids of the chunks to be used as positive examples for the recommendation. The chunks in this array will be used to find similar chunks..</param>
        public RecommendChunksRequest(ChunkFilter filters = default(ChunkFilter), long? limit = default(long?), List<Guid> negativeChunkIds = default(List<Guid>), List<string> negativeTrackingIds = default(List<string>), List<Guid> positiveChunkIds = default(List<Guid>), List<string> positiveTrackingIds = default(List<string>))
        {
            this.Filters = filters;
            this.Limit = limit;
            this.NegativeChunkIds = negativeChunkIds;
            this.NegativeTrackingIds = negativeTrackingIds;
            this.PositiveChunkIds = positiveChunkIds;
            this.PositiveTrackingIds = positiveTrackingIds;
        }

        /// <summary>
        /// Gets or Sets Filters
        /// </summary>
        [DataMember(Name = "filters", EmitDefaultValue = true)]
        public ChunkFilter Filters { get; set; }

        /// <summary>
        /// The number of chunks to return. This is the number of chunks which will be returned in the response. The default is 10.
        /// </summary>
        /// <value>The number of chunks to return. This is the number of chunks which will be returned in the response. The default is 10.</value>
        [DataMember(Name = "limit", EmitDefaultValue = true)]
        public long? Limit { get; set; }

        /// <summary>
        /// The ids of the chunks to be used as negative examples for the recommendation. The chunks in this array will be used to filter out similar chunks.
        /// </summary>
        /// <value>The ids of the chunks to be used as negative examples for the recommendation. The chunks in this array will be used to filter out similar chunks.</value>
        [DataMember(Name = "negative_chunk_ids", EmitDefaultValue = true)]
        public List<Guid> NegativeChunkIds { get; set; }

        /// <summary>
        /// The tracking_ids of the chunks to be used as negative examples for the recommendation. The chunks in this array will be used to filter out similar chunks.
        /// </summary>
        /// <value>The tracking_ids of the chunks to be used as negative examples for the recommendation. The chunks in this array will be used to filter out similar chunks.</value>
        [DataMember(Name = "negative_tracking_ids", EmitDefaultValue = true)]
        public List<string> NegativeTrackingIds { get; set; }

        /// <summary>
        /// The ids of the chunks to be used as positive examples for the recommendation. The chunks in this array will be used to find similar chunks.
        /// </summary>
        /// <value>The ids of the chunks to be used as positive examples for the recommendation. The chunks in this array will be used to find similar chunks.</value>
        [DataMember(Name = "positive_chunk_ids", EmitDefaultValue = true)]
        public List<Guid> PositiveChunkIds { get; set; }

        /// <summary>
        /// The tracking_ids of the chunks to be used as positive examples for the recommendation. The chunks in this array will be used to find similar chunks.
        /// </summary>
        /// <value>The tracking_ids of the chunks to be used as positive examples for the recommendation. The chunks in this array will be used to find similar chunks.</value>
        [DataMember(Name = "positive_tracking_ids", EmitDefaultValue = true)]
        public List<string> PositiveTrackingIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecommendChunksRequest {\n");
            sb.Append("  Filters: ").Append(Filters).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  NegativeChunkIds: ").Append(NegativeChunkIds).Append("\n");
            sb.Append("  NegativeTrackingIds: ").Append(NegativeTrackingIds).Append("\n");
            sb.Append("  PositiveChunkIds: ").Append(PositiveChunkIds).Append("\n");
            sb.Append("  PositiveTrackingIds: ").Append(PositiveTrackingIds).Append("\n");
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
            // Limit (long?) minimum
            if (this.Limit < (long?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Limit, must be a value greater than or equal to 0.", new [] { "Limit" });
            }

            yield break;
        }
    }

}
