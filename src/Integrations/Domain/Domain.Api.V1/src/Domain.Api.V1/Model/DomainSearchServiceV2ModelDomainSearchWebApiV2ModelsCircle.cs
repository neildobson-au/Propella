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
    /// DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsCircle
    /// </summary>
    [DataContract(Name = "Domain.SearchService.v2.Model.DomainSearchWebApiV2ModelsCircle")]
    public partial class DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsCircle : IEquatable<DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsCircle>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsCircle" /> class.
        /// </summary>
        /// <param name="center">center.</param>
        /// <param name="radiusInMeters">radiusInMeters.</param>
        public DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsCircle(DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsGeoPoint center = default(DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsGeoPoint), int radiusInMeters = default(int))
        {
            this.Center = center;
            this.RadiusInMeters = radiusInMeters;
        }

        /// <summary>
        /// Gets or Sets Center
        /// </summary>
        [DataMember(Name = "center", EmitDefaultValue = false)]
        public DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsGeoPoint Center { get; set; }

        /// <summary>
        /// Gets or Sets RadiusInMeters
        /// </summary>
        [DataMember(Name = "radiusInMeters", EmitDefaultValue = false)]
        public int RadiusInMeters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsCircle {\n");
            sb.Append("  Center: ").Append(Center).Append("\n");
            sb.Append("  RadiusInMeters: ").Append(RadiusInMeters).Append("\n");
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
            return this.Equals(input as DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsCircle);
        }

        /// <summary>
        /// Returns true if DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsCircle instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsCircle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainSearchServiceV2ModelDomainSearchWebApiV2ModelsCircle input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Center == input.Center ||
                    (this.Center != null &&
                    this.Center.Equals(input.Center))
                ) && 
                (
                    this.RadiusInMeters == input.RadiusInMeters ||
                    this.RadiusInMeters.Equals(input.RadiusInMeters)
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
                if (this.Center != null)
                    hashCode = hashCode * 59 + this.Center.GetHashCode();
                hashCode = hashCode * 59 + this.RadiusInMeters.GetHashCode();
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
