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
    /// Sold Details
    /// </summary>
    [DataContract(Name = "Domain.ListingAdminService.v1.Model.SoldDetails")]
    public partial class DomainListingAdminServiceV1ModelSoldDetails : IEquatable<DomainListingAdminServiceV1ModelSoldDetails>, IValidatableObject
    {
        /// <summary>
        /// Sold Type
        /// </summary>
        /// <value>Sold Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SoldTypeEnum
        {
            /// <summary>
            /// Enum Auction for value: auction
            /// </summary>
            [EnumMember(Value = "auction")]
            Auction = 1,

            /// <summary>
            /// Enum PrivateTreaty for value: privateTreaty
            /// </summary>
            [EnumMember(Value = "privateTreaty")]
            PrivateTreaty = 2,

            /// <summary>
            /// Enum PriorToAuction for value: priorToAuction
            /// </summary>
            [EnumMember(Value = "priorToAuction")]
            PriorToAuction = 3

        }

        /// <summary>
        /// Sold Type
        /// </summary>
        /// <value>Sold Type</value>
        [DataMember(Name = "soldType", EmitDefaultValue = false)]
        public SoldTypeEnum? SoldType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainListingAdminServiceV1ModelSoldDetails" /> class.
        /// </summary>
        /// <param name="soldType">Sold Type.</param>
        /// <param name="soldPrice">Price property was sold for.</param>
        /// <param name="displaySoldPrice">Indicates how the price will be displayed for free to the general public, default to true if value not provided.</param>
        public DomainListingAdminServiceV1ModelSoldDetails(SoldTypeEnum? soldType = default(SoldTypeEnum?), int soldPrice = default(int), bool displaySoldPrice = default(bool))
        {
            this.SoldType = soldType;
            this.SoldPrice = soldPrice;
            this.DisplaySoldPrice = displaySoldPrice;
        }

        /// <summary>
        /// Price property was sold for
        /// </summary>
        /// <value>Price property was sold for</value>
        [DataMember(Name = "soldPrice", EmitDefaultValue = false)]
        public int SoldPrice { get; set; }

        /// <summary>
        /// Indicates how the price will be displayed for free to the general public, default to true if value not provided
        /// </summary>
        /// <value>Indicates how the price will be displayed for free to the general public, default to true if value not provided</value>
        [DataMember(Name = "displaySoldPrice", EmitDefaultValue = false)]
        public bool DisplaySoldPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainListingAdminServiceV1ModelSoldDetails {\n");
            sb.Append("  SoldType: ").Append(SoldType).Append("\n");
            sb.Append("  SoldPrice: ").Append(SoldPrice).Append("\n");
            sb.Append("  DisplaySoldPrice: ").Append(DisplaySoldPrice).Append("\n");
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
            return this.Equals(input as DomainListingAdminServiceV1ModelSoldDetails);
        }

        /// <summary>
        /// Returns true if DomainListingAdminServiceV1ModelSoldDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainListingAdminServiceV1ModelSoldDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainListingAdminServiceV1ModelSoldDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SoldType == input.SoldType ||
                    this.SoldType.Equals(input.SoldType)
                ) && 
                (
                    this.SoldPrice == input.SoldPrice ||
                    this.SoldPrice.Equals(input.SoldPrice)
                ) && 
                (
                    this.DisplaySoldPrice == input.DisplaySoldPrice ||
                    this.DisplaySoldPrice.Equals(input.DisplaySoldPrice)
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
                hashCode = hashCode * 59 + this.SoldType.GetHashCode();
                hashCode = hashCode * 59 + this.SoldPrice.GetHashCode();
                hashCode = hashCode * 59 + this.DisplaySoldPrice.GetHashCode();
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
