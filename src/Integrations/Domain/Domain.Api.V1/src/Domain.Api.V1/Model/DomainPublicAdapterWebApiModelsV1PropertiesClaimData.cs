/*
 * Domain Public API
 *
 * See https://developer.domain.com.au for more information
 *
 * The version of the OpenAPI document: v1
 * Contact: api@domain.com.au
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
using OpenAPIDateConverter = Domain.Api.V1.Client.OpenAPIDateConverter;

namespace Domain.Api.V1.Model
{
    /// <summary>
    /// The additional claim data information about the property.
    /// </summary>
    [DataContract(Name = "Domain.Public.Adapter.Web.Api.Models.v1.Properties.ClaimData")]
    public partial class DomainPublicAdapterWebApiModelsV1PropertiesClaimData : IEquatable<DomainPublicAdapterWebApiModelsV1PropertiesClaimData>, IValidatableObject
    {
        /// <summary>
        /// Gets or sets the claimant info.
        /// </summary>
        /// <value>Gets or sets the claimant info.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ClaimantEnum
        {
            /// <summary>
            /// Enum Owner for value: Owner
            /// </summary>
            [EnumMember(Value = "Owner")]
            Owner = 1,

            /// <summary>
            /// Enum Tenant for value: Tenant
            /// </summary>
            [EnumMember(Value = "Tenant")]
            Tenant = 2,

            /// <summary>
            /// Enum Investor for value: Investor
            /// </summary>
            [EnumMember(Value = "Investor")]
            Investor = 3

        }

        /// <summary>
        /// Gets or sets the claimant info.
        /// </summary>
        /// <value>Gets or sets the claimant info.</value>
        [DataMember(Name = "claimant", EmitDefaultValue = false)]
        public ClaimantEnum? Claimant { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainPublicAdapterWebApiModelsV1PropertiesClaimData" /> class.
        /// </summary>
        /// <param name="claimant">Gets or sets the claimant info..</param>
        public DomainPublicAdapterWebApiModelsV1PropertiesClaimData(ClaimantEnum? claimant = default(ClaimantEnum?))
        {
            this.Claimant = claimant;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainPublicAdapterWebApiModelsV1PropertiesClaimData {\n");
            sb.Append("  Claimant: ").Append(Claimant).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DomainPublicAdapterWebApiModelsV1PropertiesClaimData);
        }

        /// <summary>
        /// Returns true if DomainPublicAdapterWebApiModelsV1PropertiesClaimData instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainPublicAdapterWebApiModelsV1PropertiesClaimData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainPublicAdapterWebApiModelsV1PropertiesClaimData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Claimant == input.Claimant ||
                    this.Claimant.Equals(input.Claimant)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.Claimant.GetHashCode();
                return hashCode;
            }
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
