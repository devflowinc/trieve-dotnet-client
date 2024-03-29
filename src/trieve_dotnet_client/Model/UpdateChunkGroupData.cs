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
    /// UpdateChunkGroupData
    /// </summary>
    [DataContract(Name = "UpdateChunkGroupData")]
    public partial class UpdateChunkGroupData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChunkGroupData" /> class.
        /// </summary>
        /// <param name="description">Description to assign to the chunk_group. Convenience field for you to avoid having to remember what the group is for. If not provided, the description will not be updated..</param>
        /// <param name="groupId">Id of the chunk_group to update..</param>
        /// <param name="name">Name to assign to the chunk_group. Does not need to be unique. If not provided, the name will not be updated..</param>
        /// <param name="trackingId">Tracking Id of the chunk_group to update..</param>
        public UpdateChunkGroupData(string description = default(string), Guid? groupId = default(Guid?), string name = default(string), string trackingId = default(string))
        {
            this.Description = description;
            this.GroupId = groupId;
            this.Name = name;
            this.TrackingId = trackingId;
        }

        /// <summary>
        /// Description to assign to the chunk_group. Convenience field for you to avoid having to remember what the group is for. If not provided, the description will not be updated.
        /// </summary>
        /// <value>Description to assign to the chunk_group. Convenience field for you to avoid having to remember what the group is for. If not provided, the description will not be updated.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Id of the chunk_group to update.
        /// </summary>
        /// <value>Id of the chunk_group to update.</value>
        [DataMember(Name = "group_id", EmitDefaultValue = true)]
        public Guid? GroupId { get; set; }

        /// <summary>
        /// Name to assign to the chunk_group. Does not need to be unique. If not provided, the name will not be updated.
        /// </summary>
        /// <value>Name to assign to the chunk_group. Does not need to be unique. If not provided, the name will not be updated.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Tracking Id of the chunk_group to update.
        /// </summary>
        /// <value>Tracking Id of the chunk_group to update.</value>
        [DataMember(Name = "tracking_id", EmitDefaultValue = true)]
        public string TrackingId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateChunkGroupData {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TrackingId: ").Append(TrackingId).Append("\n");
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