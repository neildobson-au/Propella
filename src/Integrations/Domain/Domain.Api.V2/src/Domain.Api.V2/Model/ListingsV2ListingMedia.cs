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
    /// Encapsulates media associated with a Listing
    /// </summary>
    [DataContract(Name = "Listings.V2.ListingMedia")]
    public partial class ListingsV2ListingMedia : IEquatable<ListingsV2ListingMedia>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingsV2ListingMedia" /> class.
        /// </summary>
        /// <param name="category">category.</param>
        /// <param name="type">type.</param>
        /// <param name="url">The URL to the property media.</param>
        public ListingsV2ListingMedia(ListingsV2ListingMediaCategory category = default(ListingsV2ListingMediaCategory), ListingsV2ListingMediaType type = default(ListingsV2ListingMediaType), string url = default(string))
        {
            this.Category = category;
            this.Type = type;
            this.Url = url;
        }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public ListingsV2ListingMediaCategory Category { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public ListingsV2ListingMediaType Type { get; set; }

        /// <summary>
        /// The URL to the property media
        /// </summary>
        /// <value>The URL to the property media</value>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListingsV2ListingMedia {\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as ListingsV2ListingMedia);
        }

        /// <summary>
        /// Returns true if ListingsV2ListingMedia instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingsV2ListingMedia to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingsV2ListingMedia input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
