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
    /// Listing search. Parking search criteria
    /// </summary>
    [DataContract(Name = "Domain.Public.Adapter.Web.Api.Models.v1.Listings.Commercial.ParkingSearch")]
    public partial class DomainPublicAdapterWebApiModelsV1ListingsCommercialParkingSearch : IEquatable<DomainPublicAdapterWebApiModelsV1ListingsCommercialParkingSearch>, IValidatableObject
    {
        /// <summary>
        /// Parking type
        /// </summary>
        /// <value>Parking type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum OnSite for value: onSite
            /// </summary>
            [EnumMember(Value = "onSite")]
            OnSite = 1,

            /// <summary>
            /// Enum OnStreet for value: onStreet
            /// </summary>
            [EnumMember(Value = "onStreet")]
            OnStreet = 2,

            /// <summary>
            /// Enum NoParking for value: noParking
            /// </summary>
            [EnumMember(Value = "noParking")]
            NoParking = 3

        }

        /// <summary>
        /// Parking type
        /// </summary>
        /// <value>Parking type</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainPublicAdapterWebApiModelsV1ListingsCommercialParkingSearch" /> class.
        /// </summary>
        /// <param name="type">Parking type.</param>
        /// <param name="carspaces">Minimum carspace count.</param>
        public DomainPublicAdapterWebApiModelsV1ListingsCommercialParkingSearch(TypeEnum? type = default(TypeEnum?), int carspaces = default(int))
        {
            this.Type = type;
            this.Carspaces = carspaces;
        }

        /// <summary>
        /// Minimum carspace count
        /// </summary>
        /// <value>Minimum carspace count</value>
        [DataMember(Name = "carspaces", EmitDefaultValue = false)]
        public int Carspaces { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainPublicAdapterWebApiModelsV1ListingsCommercialParkingSearch {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Carspaces: ").Append(Carspaces).Append("\n");
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
            return this.Equals(input as DomainPublicAdapterWebApiModelsV1ListingsCommercialParkingSearch);
        }

        /// <summary>
        /// Returns true if DomainPublicAdapterWebApiModelsV1ListingsCommercialParkingSearch instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainPublicAdapterWebApiModelsV1ListingsCommercialParkingSearch to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainPublicAdapterWebApiModelsV1ListingsCommercialParkingSearch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Carspaces == input.Carspaces ||
                    this.Carspaces.Equals(input.Carspaces)
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
                hashCode = hashCode * 59 + this.Carspaces.GetHashCode();
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
