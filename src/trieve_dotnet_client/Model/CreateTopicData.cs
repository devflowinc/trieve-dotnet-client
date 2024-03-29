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
    /// CreateTopicData
    /// </summary>
    [DataContract(Name = "CreateTopicData")]
    public partial class CreateTopicData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTopicData" /> class.
        /// </summary>
        /// <param name="firstUserMessage">The first message which will belong to the topic. The topic name is generated based on this message similar to how it works in the OpenAI chat UX if a name is not explicitly provided on the name request body key..</param>
        /// <param name="model">The model to use for the assistant&#39;s messages. This can be any model from the openrouter model list. If no model is provided, the gpt-3.5-turbo will be used..</param>
        /// <param name="name">The name of the topic. If this is not provided, the topic name is generated from the first_user_message..</param>
        public CreateTopicData(string firstUserMessage = default(string), string model = default(string), string name = default(string))
        {
            this.FirstUserMessage = firstUserMessage;
            this.Model = model;
            this.Name = name;
        }

        /// <summary>
        /// The first message which will belong to the topic. The topic name is generated based on this message similar to how it works in the OpenAI chat UX if a name is not explicitly provided on the name request body key.
        /// </summary>
        /// <value>The first message which will belong to the topic. The topic name is generated based on this message similar to how it works in the OpenAI chat UX if a name is not explicitly provided on the name request body key.</value>
        [DataMember(Name = "first_user_message", EmitDefaultValue = true)]
        public string FirstUserMessage { get; set; }

        /// <summary>
        /// The model to use for the assistant&#39;s messages. This can be any model from the openrouter model list. If no model is provided, the gpt-3.5-turbo will be used.
        /// </summary>
        /// <value>The model to use for the assistant&#39;s messages. This can be any model from the openrouter model list. If no model is provided, the gpt-3.5-turbo will be used.</value>
        [DataMember(Name = "model", EmitDefaultValue = true)]
        public string Model { get; set; }

        /// <summary>
        /// The name of the topic. If this is not provided, the topic name is generated from the first_user_message.
        /// </summary>
        /// <value>The name of the topic. If this is not provided, the topic name is generated from the first_user_message.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTopicData {\n");
            sb.Append("  FirstUserMessage: ").Append(FirstUserMessage).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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