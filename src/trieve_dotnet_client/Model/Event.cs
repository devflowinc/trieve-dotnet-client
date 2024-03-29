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
    /// Event
    /// </summary>
    [DataContract(Name = "Event")]
    public partial class Event : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Event() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Event" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="datasetId">datasetId (required).</param>
        /// <param name="eventData">eventData (required).</param>
        /// <param name="eventType">eventType (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        public Event(DateTime createdAt = default(DateTime), Guid datasetId = default(Guid), Object eventData = default(Object), string eventType = default(string), Guid id = default(Guid), DateTime updatedAt = default(DateTime))
        {
            this.CreatedAt = createdAt;
            this.DatasetId = datasetId;
            // to ensure "eventData" is required (not null)
            if (eventData == null)
            {
                throw new ArgumentNullException("eventData is a required property for Event and cannot be null");
            }
            this.EventData = eventData;
            // to ensure "eventType" is required (not null)
            if (eventType == null)
            {
                throw new ArgumentNullException("eventType is a required property for Event and cannot be null");
            }
            this.EventType = eventType;
            this.Id = id;
            this.UpdatedAt = updatedAt;
        }

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
        /// Gets or Sets EventData
        /// </summary>
        [DataMember(Name = "event_data", IsRequired = true, EmitDefaultValue = true)]
        public Object EventData { get; set; }

        /// <summary>
        /// Gets or Sets EventType
        /// </summary>
        [DataMember(Name = "event_type", IsRequired = true, EmitDefaultValue = true)]
        public string EventType { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Event {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DatasetId: ").Append(DatasetId).Append("\n");
            sb.Append("  EventData: ").Append(EventData).Append("\n");
            sb.Append("  EventType: ").Append(EventType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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