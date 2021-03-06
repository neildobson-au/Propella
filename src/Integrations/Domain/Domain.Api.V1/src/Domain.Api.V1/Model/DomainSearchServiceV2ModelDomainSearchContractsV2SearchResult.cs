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
    /// DomainSearchServiceV2ModelDomainSearchContractsV2SearchResult
    /// </summary>
    [DataContract(Name = "Domain.SearchService.v2.Model.DomainSearchContractsV2SearchResult")]
    public partial class DomainSearchServiceV2ModelDomainSearchContractsV2SearchResult : IEquatable<DomainSearchServiceV2ModelDomainSearchContractsV2SearchResult>, IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum PropertyListing for value: PropertyListing
            /// </summary>
            [EnumMember(Value = "PropertyListing")]
            PropertyListing = 1,

            /// <summary>
            /// Enum Project for value: Project
            /// </summary>
            [EnumMember(Value = "Project")]
            Project = 2

        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainSearchServiceV2ModelDomainSearchContractsV2SearchResult" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="listing">listing.</param>
        /// <param name="listings">listings.</param>
        /// <param name="project">project.</param>
        public DomainSearchServiceV2ModelDomainSearchContractsV2SearchResult(TypeEnum? type = default(TypeEnum?), DomainSearchServiceV2ModelDomainSearchContractsV2PropertyListing listing = default(DomainSearchServiceV2ModelDomainSearchContractsV2PropertyListing), List<DomainSearchServiceV2ModelDomainSearchContractsV2PropertyListing> listings = default(List<DomainSearchServiceV2ModelDomainSearchContractsV2PropertyListing>), DomainSearchServiceV2ModelDomainSearchContractsV2Project project = default(DomainSearchServiceV2ModelDomainSearchContractsV2Project))
        {
            this.Type = type;
            this.Listing = listing;
            this.Listings = listings;
            this.Project = project;
        }

        /// <summary>
        /// Gets or Sets Listing
        /// </summary>
        [DataMember(Name = "listing", EmitDefaultValue = false)]
        public DomainSearchServiceV2ModelDomainSearchContractsV2PropertyListing Listing { get; set; }

        /// <summary>
        /// Gets or Sets Listings
        /// </summary>
        [DataMember(Name = "listings", EmitDefaultValue = false)]
        public List<DomainSearchServiceV2ModelDomainSearchContractsV2PropertyListing> Listings { get; set; }

        /// <summary>
        /// Gets or Sets Project
        /// </summary>
        [DataMember(Name = "project", EmitDefaultValue = false)]
        public DomainSearchServiceV2ModelDomainSearchContractsV2Project Project { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainSearchServiceV2ModelDomainSearchContractsV2SearchResult {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Listing: ").Append(Listing).Append("\n");
            sb.Append("  Listings: ").Append(Listings).Append("\n");
            sb.Append("  Project: ").Append(Project).Append("\n");
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
            return this.Equals(input as DomainSearchServiceV2ModelDomainSearchContractsV2SearchResult);
        }

        /// <summary>
        /// Returns true if DomainSearchServiceV2ModelDomainSearchContractsV2SearchResult instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainSearchServiceV2ModelDomainSearchContractsV2SearchResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainSearchServiceV2ModelDomainSearchContractsV2SearchResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Listing == input.Listing ||
                    (this.Listing != null &&
                    this.Listing.Equals(input.Listing))
                ) && 
                (
                    this.Listings == input.Listings ||
                    this.Listings != null &&
                    input.Listings != null &&
                    this.Listings.SequenceEqual(input.Listings)
                ) && 
                (
                    this.Project == input.Project ||
                    (this.Project != null &&
                    this.Project.Equals(input.Project))
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Listing != null)
                    hashCode = hashCode * 59 + this.Listing.GetHashCode();
                if (this.Listings != null)
                    hashCode = hashCode * 59 + this.Listings.GetHashCode();
                if (this.Project != null)
                    hashCode = hashCode * 59 + this.Project.GetHashCode();
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
