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
    /// ClientDatasetConfiguration
    /// </summary>
    [DataContract(Name = "ClientDatasetConfiguration")]
    public partial class ClientDatasetConfiguration : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientDatasetConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ClientDatasetConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientDatasetConfiguration" /> class.
        /// </summary>
        /// <param name="cREATECHUNKFEATURE">cREATECHUNKFEATURE.</param>
        /// <param name="dATERANGEVALUE">dATERANGEVALUE.</param>
        /// <param name="dOCUMENTUPLOADFEATURE">dOCUMENTUPLOADFEATURE.</param>
        /// <param name="fILENAMEKEY">fILENAMEKEY (required).</param>
        /// <param name="fILTERITEMS">fILTERITEMS.</param>
        /// <param name="fRONTMATTERVALS">fRONTMATTERVALS.</param>
        /// <param name="iMAGERANGEENDKEY">iMAGERANGEENDKEY.</param>
        /// <param name="iMAGERANGESTARTKEY">iMAGERANGESTARTKEY.</param>
        /// <param name="lINESBEFORESHOWMORE">lINESBEFORESHOWMORE.</param>
        /// <param name="sEARCHQUERIES">sEARCHQUERIES.</param>
        /// <param name="sUGGESTEDQUERIES">sUGGESTEDQUERIES.</param>
        public ClientDatasetConfiguration(bool? cREATECHUNKFEATURE = default(bool?), string dATERANGEVALUE = default(string), bool? dOCUMENTUPLOADFEATURE = default(bool?), string fILENAMEKEY = default(string), Object fILTERITEMS = default(Object), string fRONTMATTERVALS = default(string), string iMAGERANGEENDKEY = default(string), string iMAGERANGESTARTKEY = default(string), int? lINESBEFORESHOWMORE = default(int?), string sEARCHQUERIES = default(string), string sUGGESTEDQUERIES = default(string))
        {
            // to ensure "fILENAMEKEY" is required (not null)
            if (fILENAMEKEY == null)
            {
                throw new ArgumentNullException("fILENAMEKEY is a required property for ClientDatasetConfiguration and cannot be null");
            }
            this.FILE_NAME_KEY = fILENAMEKEY;
            this.CREATE_CHUNK_FEATURE = cREATECHUNKFEATURE;
            this.DATE_RANGE_VALUE = dATERANGEVALUE;
            this.DOCUMENT_UPLOAD_FEATURE = dOCUMENTUPLOADFEATURE;
            this.FILTER_ITEMS = fILTERITEMS;
            this.FRONTMATTER_VALS = fRONTMATTERVALS;
            this.IMAGE_RANGE_END_KEY = iMAGERANGEENDKEY;
            this.IMAGE_RANGE_START_KEY = iMAGERANGESTARTKEY;
            this.LINES_BEFORE_SHOW_MORE = lINESBEFORESHOWMORE;
            this.SEARCH_QUERIES = sEARCHQUERIES;
            this.SUGGESTED_QUERIES = sUGGESTEDQUERIES;
        }

        /// <summary>
        /// Gets or Sets CREATE_CHUNK_FEATURE
        /// </summary>
        [DataMember(Name = "CREATE_CHUNK_FEATURE", EmitDefaultValue = true)]
        public bool? CREATE_CHUNK_FEATURE { get; set; }

        /// <summary>
        /// Gets or Sets DATE_RANGE_VALUE
        /// </summary>
        [DataMember(Name = "DATE_RANGE_VALUE", EmitDefaultValue = true)]
        public string DATE_RANGE_VALUE { get; set; }

        /// <summary>
        /// Gets or Sets DOCUMENT_UPLOAD_FEATURE
        /// </summary>
        [DataMember(Name = "DOCUMENT_UPLOAD_FEATURE", EmitDefaultValue = true)]
        public bool? DOCUMENT_UPLOAD_FEATURE { get; set; }

        /// <summary>
        /// Gets or Sets FILE_NAME_KEY
        /// </summary>
        [DataMember(Name = "FILE_NAME_KEY", IsRequired = true, EmitDefaultValue = true)]
        public string FILE_NAME_KEY { get; set; }

        /// <summary>
        /// Gets or Sets FILTER_ITEMS
        /// </summary>
        [DataMember(Name = "FILTER_ITEMS", EmitDefaultValue = true)]
        public Object FILTER_ITEMS { get; set; }

        /// <summary>
        /// Gets or Sets FRONTMATTER_VALS
        /// </summary>
        [DataMember(Name = "FRONTMATTER_VALS", EmitDefaultValue = true)]
        public string FRONTMATTER_VALS { get; set; }

        /// <summary>
        /// Gets or Sets IMAGE_RANGE_END_KEY
        /// </summary>
        [DataMember(Name = "IMAGE_RANGE_END_KEY", EmitDefaultValue = true)]
        public string IMAGE_RANGE_END_KEY { get; set; }

        /// <summary>
        /// Gets or Sets IMAGE_RANGE_START_KEY
        /// </summary>
        [DataMember(Name = "IMAGE_RANGE_START_KEY", EmitDefaultValue = true)]
        public string IMAGE_RANGE_START_KEY { get; set; }

        /// <summary>
        /// Gets or Sets LINES_BEFORE_SHOW_MORE
        /// </summary>
        [DataMember(Name = "LINES_BEFORE_SHOW_MORE", EmitDefaultValue = true)]
        public int? LINES_BEFORE_SHOW_MORE { get; set; }

        /// <summary>
        /// Gets or Sets SEARCH_QUERIES
        /// </summary>
        [DataMember(Name = "SEARCH_QUERIES", EmitDefaultValue = true)]
        public string SEARCH_QUERIES { get; set; }

        /// <summary>
        /// Gets or Sets SUGGESTED_QUERIES
        /// </summary>
        [DataMember(Name = "SUGGESTED_QUERIES", EmitDefaultValue = true)]
        public string SUGGESTED_QUERIES { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientDatasetConfiguration {\n");
            sb.Append("  CREATE_CHUNK_FEATURE: ").Append(CREATE_CHUNK_FEATURE).Append("\n");
            sb.Append("  DATE_RANGE_VALUE: ").Append(DATE_RANGE_VALUE).Append("\n");
            sb.Append("  DOCUMENT_UPLOAD_FEATURE: ").Append(DOCUMENT_UPLOAD_FEATURE).Append("\n");
            sb.Append("  FILE_NAME_KEY: ").Append(FILE_NAME_KEY).Append("\n");
            sb.Append("  FILTER_ITEMS: ").Append(FILTER_ITEMS).Append("\n");
            sb.Append("  FRONTMATTER_VALS: ").Append(FRONTMATTER_VALS).Append("\n");
            sb.Append("  IMAGE_RANGE_END_KEY: ").Append(IMAGE_RANGE_END_KEY).Append("\n");
            sb.Append("  IMAGE_RANGE_START_KEY: ").Append(IMAGE_RANGE_START_KEY).Append("\n");
            sb.Append("  LINES_BEFORE_SHOW_MORE: ").Append(LINES_BEFORE_SHOW_MORE).Append("\n");
            sb.Append("  SEARCH_QUERIES: ").Append(SEARCH_QUERIES).Append("\n");
            sb.Append("  SUGGESTED_QUERIES: ").Append(SUGGESTED_QUERIES).Append("\n");
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
            // LINES_BEFORE_SHOW_MORE (int?) minimum
            if (this.LINES_BEFORE_SHOW_MORE < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LINES_BEFORE_SHOW_MORE, must be a value greater than or equal to 0.", new [] { "LINES_BEFORE_SHOW_MORE" });
            }

            yield break;
        }
    }

}
