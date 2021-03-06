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
    /// Parking Details
    /// </summary>
    [DataContract(Name = "Domain.ListingAdminService.v1.Model.ParkingInfo")]
    public partial class DomainListingAdminServiceV1ModelParkingInfo : IEquatable<DomainListingAdminServiceV1ModelParkingInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainListingAdminServiceV1ModelParkingInfo" /> class.
        /// </summary>
        /// <param name="details">Details for available parking spaces.</param>
        /// <param name="information">Additional information regarding the parking condition.</param>
        public DomainListingAdminServiceV1ModelParkingInfo(List<DomainListingAdminServiceV1ModelParkingDetails> details = default(List<DomainListingAdminServiceV1ModelParkingDetails>), string information = default(string))
        {
            this.Details = details;
            this.Information = information;
        }

        /// <summary>
        /// Details for available parking spaces
        /// </summary>
        /// <value>Details for available parking spaces</value>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public List<DomainListingAdminServiceV1ModelParkingDetails> Details { get; set; }

        /// <summary>
        /// Additional information regarding the parking condition
        /// </summary>
        /// <value>Additional information regarding the parking condition</value>
        [DataMember(Name = "information", EmitDefaultValue = false)]
        public string Information { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainListingAdminServiceV1ModelParkingInfo {\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Information: ").Append(Information).Append("\n");
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
            return this.Equals(input as DomainListingAdminServiceV1ModelParkingInfo);
        }

        /// <summary>
        /// Returns true if DomainListingAdminServiceV1ModelParkingInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainListingAdminServiceV1ModelParkingInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainListingAdminServiceV1ModelParkingInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.Information == input.Information ||
                    (this.Information != null &&
                    this.Information.Equals(input.Information))
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
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Information != null)
                    hashCode = hashCode * 59 + this.Information.GetHashCode();
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
