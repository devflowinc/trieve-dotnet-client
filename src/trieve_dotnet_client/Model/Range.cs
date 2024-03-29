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
    /// Range
    /// </summary>
    [DataContract(Name = "Range")]
    public partial class Range : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Range" /> class.
        /// </summary>
        /// <param name="gt">gt.</param>
        /// <param name="gte">gte.</param>
        /// <param name="lt">lt.</param>
        /// <param name="lte">lte.</param>
        public Range(double? gt = default(double?), double? gte = default(double?), double? lt = default(double?), double? lte = default(double?))
        {
            this.Gt = gt;
            this.Gte = gte;
            this.Lt = lt;
            this.Lte = lte;
        }

        /// <summary>
        /// Gets or Sets Gt
        /// </summary>
        [DataMember(Name = "gt", EmitDefaultValue = true)]
        public double? Gt { get; set; }

        /// <summary>
        /// Gets or Sets Gte
        /// </summary>
        [DataMember(Name = "gte", EmitDefaultValue = true)]
        public double? Gte { get; set; }

        /// <summary>
        /// Gets or Sets Lt
        /// </summary>
        [DataMember(Name = "lt", EmitDefaultValue = true)]
        public double? Lt { get; set; }

        /// <summary>
        /// Gets or Sets Lte
        /// </summary>
        [DataMember(Name = "lte", EmitDefaultValue = true)]
        public double? Lte { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Range {\n");
            sb.Append("  Gt: ").Append(Gt).Append("\n");
            sb.Append("  Gte: ").Append(Gte).Append("\n");
            sb.Append("  Lt: ").Append(Lt).Append("\n");
            sb.Append("  Lte: ").Append(Lte).Append("\n");
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
