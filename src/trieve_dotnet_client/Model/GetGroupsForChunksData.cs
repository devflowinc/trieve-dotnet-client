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
    /// GetGroupsForChunksData
    /// </summary>
    [DataContract(Name = "GetGroupsForChunksData")]
    public partial class GetGroupsForChunksData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGroupsForChunksData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetGroupsForChunksData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGroupsForChunksData" /> class.
        /// </summary>
        /// <param name="chunkIds">chunkIds (required).</param>
        public GetGroupsForChunksData(List<Guid> chunkIds = default(List<Guid>))
        {
            // to ensure "chunkIds" is required (not null)
            if (chunkIds == null)
            {
                throw new ArgumentNullException("chunkIds is a required property for GetGroupsForChunksData and cannot be null");
            }
            this.ChunkIds = chunkIds;
        }

        /// <summary>
        /// Gets or Sets ChunkIds
        /// </summary>
        [DataMember(Name = "chunk_ids", IsRequired = true, EmitDefaultValue = true)]
        public List<Guid> ChunkIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetGroupsForChunksData {\n");
            sb.Append("  ChunkIds: ").Append(ChunkIds).Append("\n");
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
