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
    /// DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingProviderDetails
    /// </summary>
    [DataContract(Name = "Domain.ListingsService.v1.Model.DomainListingsApiModelQueryResultsListingProviderDetails")]
    public partial class DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingProviderDetails : IEquatable<DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingProviderDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingProviderDetails" /> class.
        /// </summary>
        /// <param name="providerSystem">providerSystem.</param>
        /// <param name="providerAdID">providerAdID.</param>
        public DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingProviderDetails(string providerSystem = default(string), string providerAdID = default(string))
        {
            this.ProviderSystem = providerSystem;
            this.ProviderAdID = providerAdID;
        }

        /// <summary>
        /// Gets or Sets ProviderSystem
        /// </summary>
        [DataMember(Name = "providerSystem", EmitDefaultValue = false)]
        public string ProviderSystem { get; set; }

        /// <summary>
        /// Gets or Sets ProviderAdID
        /// </summary>
        [DataMember(Name = "providerAdID", EmitDefaultValue = false)]
        public string ProviderAdID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingProviderDetails {\n");
            sb.Append("  ProviderSystem: ").Append(ProviderSystem).Append("\n");
            sb.Append("  ProviderAdID: ").Append(ProviderAdID).Append("\n");
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
            return this.Equals(input as DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingProviderDetails);
        }

        /// <summary>
        /// Returns true if DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingProviderDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingProviderDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingProviderDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProviderSystem == input.ProviderSystem ||
                    (this.ProviderSystem != null &&
                    this.ProviderSystem.Equals(input.ProviderSystem))
                ) && 
                (
                    this.ProviderAdID == input.ProviderAdID ||
                    (this.ProviderAdID != null &&
                    this.ProviderAdID.Equals(input.ProviderAdID))
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
                if (this.ProviderSystem != null)
                    hashCode = hashCode * 59 + this.ProviderSystem.GetHashCode();
                if (this.ProviderAdID != null)
                    hashCode = hashCode * 59 + this.ProviderAdID.GetHashCode();
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
