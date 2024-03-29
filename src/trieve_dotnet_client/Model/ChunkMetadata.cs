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
    /// ChunkMetadata
    /// </summary>
    [DataContract(Name = "ChunkMetadata")]
    public partial class ChunkMetadata : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkMetadata" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChunkMetadata() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkMetadata" /> class.
        /// </summary>
        /// <param name="chunkHtml">chunkHtml.</param>
        /// <param name="content">content (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="datasetId">datasetId (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="link">link.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="qdrantPointId">qdrantPointId.</param>
        /// <param name="tagSet">tagSet.</param>
        /// <param name="timeStamp">timeStamp.</param>
        /// <param name="trackingId">trackingId.</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="weight">weight (required).</param>
        public ChunkMetadata(string chunkHtml = default(string), string content = default(string), DateTime createdAt = default(DateTime), Guid datasetId = default(Guid), Guid id = default(Guid), string link = default(string), Object metadata = default(Object), Guid? qdrantPointId = default(Guid?), string tagSet = default(string), DateTime? timeStamp = default(DateTime?), string trackingId = default(string), DateTime updatedAt = default(DateTime), double weight = default(double))
        {
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new ArgumentNullException("content is a required property for ChunkMetadata and cannot be null");
            }
            this.Content = content;
            this.CreatedAt = createdAt;
            this.DatasetId = datasetId;
            this.Id = id;
            this.UpdatedAt = updatedAt;
            this.Weight = weight;
            this.ChunkHtml = chunkHtml;
            this.Link = link;
            this.Metadata = metadata;
            this.QdrantPointId = qdrantPointId;
            this.TagSet = tagSet;
            this.TimeStamp = timeStamp;
            this.TrackingId = trackingId;
        }

        /// <summary>
        /// Gets or Sets ChunkHtml
        /// </summary>
        [DataMember(Name = "chunk_html", EmitDefaultValue = true)]
        public string ChunkHtml { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", IsRequired = true, EmitDefaultValue = true)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets DatasetId
        /// </summary>
        [DataMember(Name = "dataset_id", IsRequired = true, EmitDefaultValue = true)]
        public Guid DatasetId { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name = "link", EmitDefaultValue = true)]
        public string Link { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Gets or Sets QdrantPointId
        /// </summary>
        [DataMember(Name = "qdrant_point_id", EmitDefaultValue = true)]
        public Guid? QdrantPointId { get; set; }

        /// <summary>
        /// Gets or Sets TagSet
        /// </summary>
        [DataMember(Name = "tag_set", EmitDefaultValue = true)]
        public string TagSet { get; set; }

        /// <summary>
        /// Gets or Sets TimeStamp
        /// </summary>
        [DataMember(Name = "time_stamp", EmitDefaultValue = true)]
        public DateTime? TimeStamp { get; set; }

        /// <summary>
        /// Gets or Sets TrackingId
        /// </summary>
        [DataMember(Name = "tracking_id", EmitDefaultValue = true)]
        public string TrackingId { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Weight
        /// </summary>
        [DataMember(Name = "weight", IsRequired = true, EmitDefaultValue = true)]
        public double Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChunkMetadata {\n");
            sb.Append("  ChunkHtml: ").Append(ChunkHtml).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DatasetId: ").Append(DatasetId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  QdrantPointId: ").Append(QdrantPointId).Append("\n");
            sb.Append("  TagSet: ").Append(TagSet).Append("\n");
            sb.Append("  TimeStamp: ").Append(TimeStamp).Append("\n");
            sb.Append("  TrackingId: ").Append(TrackingId).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
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