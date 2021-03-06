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
    /// DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SeriesHeaderModel
    /// </summary>
    [DataContract(Name = "Domain.APMService.v2.Model.APMAPIModelsSuburbV2SeriesHeaderModel")]
    public partial class DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SeriesHeaderModel : IEquatable<DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SeriesHeaderModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SeriesHeaderModel" /> class.
        /// </summary>
        /// <param name="suburb">suburb.</param>
        /// <param name="state">state.</param>
        /// <param name="propertyCategory">propertyCategory.</param>
        public DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SeriesHeaderModel(string suburb = default(string), string state = default(string), string propertyCategory = default(string))
        {
            this.Suburb = suburb;
            this.State = state;
            this.PropertyCategory = propertyCategory;
        }

        /// <summary>
        /// Gets or Sets Suburb
        /// </summary>
        [DataMember(Name = "suburb", EmitDefaultValue = false)]
        public string Suburb { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets PropertyCategory
        /// </summary>
        [DataMember(Name = "propertyCategory", EmitDefaultValue = false)]
        public string PropertyCategory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SeriesHeaderModel {\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  PropertyCategory: ").Append(PropertyCategory).Append("\n");
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
            return this.Equals(input as DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SeriesHeaderModel);
        }

        /// <summary>
        /// Returns true if DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SeriesHeaderModel instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SeriesHeaderModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainAPMServiceV2ModelAPMAPIModelsSuburbV2SeriesHeaderModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Suburb == input.Suburb ||
                    (this.Suburb != null &&
                    this.Suburb.Equals(input.Suburb))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.PropertyCategory == input.PropertyCategory ||
                    (this.PropertyCategory != null &&
                    this.PropertyCategory.Equals(input.PropertyCategory))
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
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.PropertyCategory != null)
                    hashCode = hashCode * 59 + this.PropertyCategory.GetHashCode();
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
