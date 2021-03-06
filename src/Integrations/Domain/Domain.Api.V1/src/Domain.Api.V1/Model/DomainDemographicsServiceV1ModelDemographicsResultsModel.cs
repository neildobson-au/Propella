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
    /// DomainDemographicsServiceV1ModelDemographicsResultsModel
    /// </summary>
    [DataContract(Name = "Domain.DemographicsService.v1.Model.DemographicsResultsModel")]
    public partial class DomainDemographicsServiceV1ModelDemographicsResultsModel : IEquatable<DomainDemographicsServiceV1ModelDemographicsResultsModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainDemographicsServiceV1ModelDemographicsResultsModel" /> class.
        /// </summary>
        /// <param name="demographics">demographics.</param>
        public DomainDemographicsServiceV1ModelDemographicsResultsModel(List<DomainDemographicsServiceV1ModelDemographicsModel> demographics = default(List<DomainDemographicsServiceV1ModelDemographicsModel>))
        {
            this.Demographics = demographics;
        }

        /// <summary>
        /// Gets or Sets Demographics
        /// </summary>
        [DataMember(Name = "demographics", EmitDefaultValue = false)]
        public List<DomainDemographicsServiceV1ModelDemographicsModel> Demographics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainDemographicsServiceV1ModelDemographicsResultsModel {\n");
            sb.Append("  Demographics: ").Append(Demographics).Append("\n");
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
            return this.Equals(input as DomainDemographicsServiceV1ModelDemographicsResultsModel);
        }

        /// <summary>
        /// Returns true if DomainDemographicsServiceV1ModelDemographicsResultsModel instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainDemographicsServiceV1ModelDemographicsResultsModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainDemographicsServiceV1ModelDemographicsResultsModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Demographics == input.Demographics ||
                    this.Demographics != null &&
                    input.Demographics != null &&
                    this.Demographics.SequenceEqual(input.Demographics)
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
                if (this.Demographics != null)
                    hashCode = hashCode * 59 + this.Demographics.GetHashCode();
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
