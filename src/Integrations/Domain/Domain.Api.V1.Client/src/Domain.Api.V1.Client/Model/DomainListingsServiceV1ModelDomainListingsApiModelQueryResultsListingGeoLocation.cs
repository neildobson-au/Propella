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
using OpenAPIDateConverter = Domain.Api.V1.Client.Client.OpenAPIDateConverter;

namespace Domain.Api.V1.Client.Model
{
    /// <summary>
    /// DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingGeoLocation
    /// </summary>
    [DataContract(Name = "Domain.ListingsService.v1.Model.DomainListingsApiModelQueryResultsListingGeoLocation")]
    public partial class DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingGeoLocation : IEquatable<DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingGeoLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingGeoLocation" /> class.
        /// </summary>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        public DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingGeoLocation(double latitude = default(double), double longitude = default(double))
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public double Longitude { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingGeoLocation {\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
            return this.Equals(input as DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingGeoLocation);
        }

        /// <summary>
        /// Returns true if DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingGeoLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingGeoLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainListingsServiceV1ModelDomainListingsApiModelQueryResultsListingGeoLocation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Latitude == input.Latitude ||
                    this.Latitude.Equals(input.Latitude)
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    this.Longitude.Equals(input.Longitude)
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
                hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                hashCode = hashCode * 59 + this.Longitude.GetHashCode();
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