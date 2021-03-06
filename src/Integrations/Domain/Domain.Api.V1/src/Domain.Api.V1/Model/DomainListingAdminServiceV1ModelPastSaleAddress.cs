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
    /// Address for past sold listing
    /// </summary>
    [DataContract(Name = "Domain.ListingAdminService.v1.Model.PastSaleAddress")]
    public partial class DomainListingAdminServiceV1ModelPastSaleAddress : IEquatable<DomainListingAdminServiceV1ModelPastSaleAddress>, IValidatableObject
    {
        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Enum Nsw for value: nsw
            /// </summary>
            [EnumMember(Value = "nsw")]
            Nsw = 1,

            /// <summary>
            /// Enum Vic for value: vic
            /// </summary>
            [EnumMember(Value = "vic")]
            Vic = 2,

            /// <summary>
            /// Enum Act for value: act
            /// </summary>
            [EnumMember(Value = "act")]
            Act = 3,

            /// <summary>
            /// Enum Sa for value: sa
            /// </summary>
            [EnumMember(Value = "sa")]
            Sa = 4,

            /// <summary>
            /// Enum Wa for value: wa
            /// </summary>
            [EnumMember(Value = "wa")]
            Wa = 5,

            /// <summary>
            /// Enum Tas for value: tas
            /// </summary>
            [EnumMember(Value = "tas")]
            Tas = 6,

            /// <summary>
            /// Enum Qld for value: qld
            /// </summary>
            [EnumMember(Value = "qld")]
            Qld = 7,

            /// <summary>
            /// Enum Nt for value: nt
            /// </summary>
            [EnumMember(Value = "nt")]
            Nt = 8

        }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainListingAdminServiceV1ModelPastSaleAddress" /> class.
        /// </summary>
        /// <param name="state">State.</param>
        /// <param name="unitNumber">Unit number for apartments, maximum 30 characters.</param>
        /// <param name="streetNumber">Street number, maximum 20 characters.</param>
        /// <param name="street">Street name, maximum 100 characters.</param>
        /// <param name="suburb">Suburb name , maximum 50 characters.</param>
        /// <param name="postcode">Postcode.</param>
        public DomainListingAdminServiceV1ModelPastSaleAddress(StateEnum? state = default(StateEnum?), string unitNumber = default(string), string streetNumber = default(string), string street = default(string), string suburb = default(string), string postcode = default(string))
        {
            this.State = state;
            this.UnitNumber = unitNumber;
            this.StreetNumber = streetNumber;
            this.Street = street;
            this.Suburb = suburb;
            this.Postcode = postcode;
        }

        /// <summary>
        /// Unit number for apartments, maximum 30 characters
        /// </summary>
        /// <value>Unit number for apartments, maximum 30 characters</value>
        [DataMember(Name = "unitNumber", EmitDefaultValue = false)]
        public string UnitNumber { get; set; }

        /// <summary>
        /// Street number, maximum 20 characters
        /// </summary>
        /// <value>Street number, maximum 20 characters</value>
        [DataMember(Name = "streetNumber", EmitDefaultValue = false)]
        public string StreetNumber { get; set; }

        /// <summary>
        /// Street name, maximum 100 characters
        /// </summary>
        /// <value>Street name, maximum 100 characters</value>
        [DataMember(Name = "street", EmitDefaultValue = false)]
        public string Street { get; set; }

        /// <summary>
        /// Suburb name , maximum 50 characters
        /// </summary>
        /// <value>Suburb name , maximum 50 characters</value>
        [DataMember(Name = "suburb", EmitDefaultValue = false)]
        public string Suburb { get; set; }

        /// <summary>
        /// Postcode
        /// </summary>
        /// <value>Postcode</value>
        [DataMember(Name = "postcode", EmitDefaultValue = false)]
        public string Postcode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainListingAdminServiceV1ModelPastSaleAddress {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  UnitNumber: ").Append(UnitNumber).Append("\n");
            sb.Append("  StreetNumber: ").Append(StreetNumber).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
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
            return this.Equals(input as DomainListingAdminServiceV1ModelPastSaleAddress);
        }

        /// <summary>
        /// Returns true if DomainListingAdminServiceV1ModelPastSaleAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainListingAdminServiceV1ModelPastSaleAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainListingAdminServiceV1ModelPastSaleAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.State == input.State ||
                    this.State.Equals(input.State)
                ) && 
                (
                    this.UnitNumber == input.UnitNumber ||
                    (this.UnitNumber != null &&
                    this.UnitNumber.Equals(input.UnitNumber))
                ) && 
                (
                    this.StreetNumber == input.StreetNumber ||
                    (this.StreetNumber != null &&
                    this.StreetNumber.Equals(input.StreetNumber))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.Suburb == input.Suburb ||
                    (this.Suburb != null &&
                    this.Suburb.Equals(input.Suburb))
                ) && 
                (
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                    this.Postcode.Equals(input.Postcode))
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
                hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.UnitNumber != null)
                    hashCode = hashCode * 59 + this.UnitNumber.GetHashCode();
                if (this.StreetNumber != null)
                    hashCode = hashCode * 59 + this.StreetNumber.GetHashCode();
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
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
