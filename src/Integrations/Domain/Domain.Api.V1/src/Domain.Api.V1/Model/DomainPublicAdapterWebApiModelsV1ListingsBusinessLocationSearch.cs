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
    /// Search request location details
    /// </summary>
    [DataContract(Name = "Domain.Public.Adapter.Web.Api.Models.v1.Listings.Business.LocationSearch")]
    public partial class DomainPublicAdapterWebApiModelsV1ListingsBusinessLocationSearch : IEquatable<DomainPublicAdapterWebApiModelsV1ListingsBusinessLocationSearch>, IValidatableObject
    {
        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Act for value: act
            /// </summary>
            [EnumMember(Value = "act")]
            Act = 1,

            /// <summary>
            /// Enum Nsw for value: nsw
            /// </summary>
            [EnumMember(Value = "nsw")]
            Nsw = 2,

            /// <summary>
            /// Enum Qld for value: qld
            /// </summary>
            [EnumMember(Value = "qld")]
            Qld = 3,

            /// <summary>
            /// Enum Vic for value: vic
            /// </summary>
            [EnumMember(Value = "vic")]
            Vic = 4,

            /// <summary>
            /// Enum Sa for value: sa
            /// </summary>
            [EnumMember(Value = "sa")]
            Sa = 5,

            /// <summary>
            /// Enum Wa for value: wa
            /// </summary>
            [EnumMember(Value = "wa")]
            Wa = 6,

            /// <summary>
            /// Enum Nt for value: nt
            /// </summary>
            [EnumMember(Value = "nt")]
            Nt = 7,

            /// <summary>
            /// Enum Tas for value: tas
            /// </summary>
            [EnumMember(Value = "tas")]
            Tas = 8

        }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainPublicAdapterWebApiModelsV1ListingsBusinessLocationSearch" /> class.
        /// </summary>
        /// <param name="area">Location area.</param>
        /// <param name="postcode">Location postcode.</param>
        /// <param name="region">Location region.</param>
        /// <param name="state">State.</param>
        /// <param name="suburb">Suburb.</param>
        public DomainPublicAdapterWebApiModelsV1ListingsBusinessLocationSearch(string area = default(string), string postcode = default(string), string region = default(string), StateEnum? state = default(StateEnum?), string suburb = default(string))
        {
            this.Area = area;
            this.Postcode = postcode;
            this.Region = region;
            this.State = state;
            this.Suburb = suburb;
        }

        /// <summary>
        /// Location area
        /// </summary>
        /// <value>Location area</value>
        [DataMember(Name = "area", EmitDefaultValue = false)]
        public string Area { get; set; }

        /// <summary>
        /// Location postcode
        /// </summary>
        /// <value>Location postcode</value>
        [DataMember(Name = "postcode", EmitDefaultValue = false)]
        public string Postcode { get; set; }

        /// <summary>
        /// Location region
        /// </summary>
        /// <value>Location region</value>
        [DataMember(Name = "region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// Suburb
        /// </summary>
        /// <value>Suburb</value>
        [DataMember(Name = "suburb", EmitDefaultValue = false)]
        public string Suburb { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainPublicAdapterWebApiModelsV1ListingsBusinessLocationSearch {\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
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
            return this.Equals(input as DomainPublicAdapterWebApiModelsV1ListingsBusinessLocationSearch);
        }

        /// <summary>
        /// Returns true if DomainPublicAdapterWebApiModelsV1ListingsBusinessLocationSearch instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainPublicAdapterWebApiModelsV1ListingsBusinessLocationSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainPublicAdapterWebApiModelsV1ListingsBusinessLocationSearch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Area == input.Area ||
                    (this.Area != null &&
                    this.Area.Equals(input.Area))
                ) && 
                (
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                    this.Postcode.Equals(input.Postcode))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.Suburb == input.Suburb ||
                    (this.Suburb != null &&
                    this.Suburb.Equals(input.Suburb))
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
                if (this.Area != null)
                    hashCode = hashCode * 59 + this.Area.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
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
