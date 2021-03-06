/*
 * Domain Public API
 *
 * See https://developer.domain.com.au for more information
 *
 * The version of the OpenAPI document: v2
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
using OpenAPIDateConverter = Domain.Api.V2.Client.OpenAPIDateConverter;

namespace Domain.Api.V2.Model
{
    /// <summary>
    /// Sold details in the case of the listing being sold.
    /// </summary>
    [DataContract(Name = "Listings.V2.SoldDetails")]
    public partial class ListingsV2SoldDetails : IEquatable<ListingsV2SoldDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingsV2SoldDetails" /> class.
        /// </summary>
        /// <param name="soldAction">soldAction.</param>
        /// <param name="source">source.</param>
        /// <param name="soldDate">The Date the listing was sold. DateTime is in AEST (Australian Eastern Standard Time) timezone..</param>
        /// <param name="canDisplayPrice">Indicates whether this instance can display price.</param>
        public ListingsV2SoldDetails(ListingsV2SoldAction soldAction = default(ListingsV2SoldAction), ListingsV2PublishSource source = default(ListingsV2PublishSource), DateTime? soldDate = default(DateTime?), bool canDisplayPrice = default(bool))
        {
            this.SoldAction = soldAction;
            this.Source = source;
            this.SoldDate = soldDate;
            this.CanDisplayPrice = canDisplayPrice;
        }

        /// <summary>
        /// Gets or Sets SoldAction
        /// </summary>
        [DataMember(Name = "soldAction", EmitDefaultValue = false)]
        public ListingsV2SoldAction SoldAction { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public ListingsV2PublishSource Source { get; set; }

        /// <summary>
        /// The Date the listing was sold. DateTime is in AEST (Australian Eastern Standard Time) timezone.
        /// </summary>
        /// <value>The Date the listing was sold. DateTime is in AEST (Australian Eastern Standard Time) timezone.</value>
        [DataMember(Name = "soldDate", EmitDefaultValue = true)]
        public DateTime? SoldDate { get; set; }

        /// <summary>
        /// Indicates whether this instance can display price
        /// </summary>
        /// <value>Indicates whether this instance can display price</value>
        [DataMember(Name = "canDisplayPrice", EmitDefaultValue = false)]
        public bool CanDisplayPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListingsV2SoldDetails {\n");
            sb.Append("  SoldAction: ").Append(SoldAction).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  SoldDate: ").Append(SoldDate).Append("\n");
            sb.Append("  CanDisplayPrice: ").Append(CanDisplayPrice).Append("\n");
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
            return this.Equals(input as ListingsV2SoldDetails);
        }

        /// <summary>
        /// Returns true if ListingsV2SoldDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingsV2SoldDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingsV2SoldDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SoldAction == input.SoldAction ||
                    (this.SoldAction != null &&
                    this.SoldAction.Equals(input.SoldAction))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.SoldDate == input.SoldDate ||
                    (this.SoldDate != null &&
                    this.SoldDate.Equals(input.SoldDate))
                ) && 
                (
                    this.CanDisplayPrice == input.CanDisplayPrice ||
                    this.CanDisplayPrice.Equals(input.CanDisplayPrice)
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
                if (this.SoldAction != null)
                    hashCode = hashCode * 59 + this.SoldAction.GetHashCode();
                if (this.Source != null)
                    hashCode = hashCode * 59 + this.Source.GetHashCode();
                if (this.SoldDate != null)
                    hashCode = hashCode * 59 + this.SoldDate.GetHashCode();
                hashCode = hashCode * 59 + this.CanDisplayPrice.GetHashCode();
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
