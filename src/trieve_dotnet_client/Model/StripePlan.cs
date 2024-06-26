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
    /// StripePlan
    /// </summary>
    [DataContract(Name = "StripePlan")]
    public partial class StripePlan : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StripePlan" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StripePlan() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StripePlan" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="chunkCount">chunkCount (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="datasetCount">datasetCount (required).</param>
        /// <param name="fileStorage">fileStorage (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="messageCount">messageCount (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="stripeId">stripeId (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="userCount">userCount (required).</param>
        public StripePlan(long amount = default(long), int chunkCount = default(int), DateTime createdAt = default(DateTime), int datasetCount = default(int), long fileStorage = default(long), Guid id = default(Guid), int messageCount = default(int), string name = default(string), string stripeId = default(string), DateTime updatedAt = default(DateTime), int userCount = default(int))
        {
            this.Amount = amount;
            this.ChunkCount = chunkCount;
            this.CreatedAt = createdAt;
            this.DatasetCount = datasetCount;
            this.FileStorage = fileStorage;
            this.Id = id;
            this.MessageCount = messageCount;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for StripePlan and cannot be null");
            }
            this.Name = name;
            // to ensure "stripeId" is required (not null)
            if (stripeId == null)
            {
                throw new ArgumentNullException("stripeId is a required property for StripePlan and cannot be null");
            }
            this.StripeId = stripeId;
            this.UpdatedAt = updatedAt;
            this.UserCount = userCount;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public long Amount { get; set; }

        /// <summary>
        /// Gets or Sets ChunkCount
        /// </summary>
        [DataMember(Name = "chunk_count", IsRequired = true, EmitDefaultValue = true)]
        public int ChunkCount { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets DatasetCount
        /// </summary>
        [DataMember(Name = "dataset_count", IsRequired = true, EmitDefaultValue = true)]
        public int DatasetCount { get; set; }

        /// <summary>
        /// Gets or Sets FileStorage
        /// </summary>
        [DataMember(Name = "file_storage", IsRequired = true, EmitDefaultValue = true)]
        public long FileStorage { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets MessageCount
        /// </summary>
        [DataMember(Name = "message_count", IsRequired = true, EmitDefaultValue = true)]
        public int MessageCount { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets StripeId
        /// </summary>
        [DataMember(Name = "stripe_id", IsRequired = true, EmitDefaultValue = true)]
        public string StripeId { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UserCount
        /// </summary>
        [DataMember(Name = "user_count", IsRequired = true, EmitDefaultValue = true)]
        public int UserCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StripePlan {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  ChunkCount: ").Append(ChunkCount).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DatasetCount: ").Append(DatasetCount).Append("\n");
            sb.Append("  FileStorage: ").Append(FileStorage).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MessageCount: ").Append(MessageCount).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StripeId: ").Append(StripeId).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  UserCount: ").Append(UserCount).Append("\n");
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
