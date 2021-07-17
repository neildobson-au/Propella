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
using OpenAPIDateConverter = Domain.Api.V2.Client.Client.OpenAPIDateConverter;

namespace Domain.Api.V2.Client.Model
{
    /// <summary>
    /// Information regarding the past comparable property sales that influenced the setting of the estimation price
    /// </summary>
    [DataContract(Name = "Listings.V2.ComparableData")]
    public partial class ListingsV2ComparableData : IEquatable<ListingsV2ComparableData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingsV2ComparableData" /> class.
        /// </summary>
        /// <param name="comparableProperty">Comparable properties that are of a similar standard or condition to the property for sale.</param>
        /// <param name="declarationText">Text description if there are less than three comparable sales available.</param>
        public ListingsV2ComparableData(List<ListingsV2PastSaleData> comparableProperty = default(List<ListingsV2PastSaleData>), string declarationText = default(string))
        {
            this.ComparableProperty = comparableProperty;
            this.DeclarationText = declarationText;
        }

        /// <summary>
        /// Comparable properties that are of a similar standard or condition to the property for sale
        /// </summary>
        /// <value>Comparable properties that are of a similar standard or condition to the property for sale</value>
        [DataMember(Name = "comparableProperty", EmitDefaultValue = true)]
        public List<ListingsV2PastSaleData> ComparableProperty { get; set; }

        /// <summary>
        /// Text description if there are less than three comparable sales available
        /// </summary>
        /// <value>Text description if there are less than three comparable sales available</value>
        [DataMember(Name = "declarationText", EmitDefaultValue = true)]
        public string DeclarationText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListingsV2ComparableData {\n");
            sb.Append("  ComparableProperty: ").Append(ComparableProperty).Append("\n");
            sb.Append("  DeclarationText: ").Append(DeclarationText).Append("\n");
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
            return this.Equals(input as ListingsV2ComparableData);
        }

        /// <summary>
        /// Returns true if ListingsV2ComparableData instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingsV2ComparableData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingsV2ComparableData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ComparableProperty == input.ComparableProperty ||
                    this.ComparableProperty != null &&
                    input.ComparableProperty != null &&
                    this.ComparableProperty.SequenceEqual(input.ComparableProperty)
                ) && 
                (
                    this.DeclarationText == input.DeclarationText ||
                    (this.DeclarationText != null &&
                    this.DeclarationText.Equals(input.DeclarationText))
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
                if (this.ComparableProperty != null)
                    hashCode = hashCode * 59 + this.ComparableProperty.GetHashCode();
                if (this.DeclarationText != null)
                    hashCode = hashCode * 59 + this.DeclarationText.GetHashCode();
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