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
    /// Statistics report for single listing
    /// </summary>
    [DataContract(Name = "Domain.Public.Adapter.Web.Api.Models.v1.Listings.StatisticsReport")]
    public partial class DomainPublicAdapterWebApiModelsV1ListingsStatisticsReport : IEquatable<DomainPublicAdapterWebApiModelsV1ListingsStatisticsReport>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainPublicAdapterWebApiModelsV1ListingsStatisticsReport" /> class.
        /// </summary>
        /// <param name="summary">summary.</param>
        /// <param name="dailyBreakdown">Listing statistic breakdown for the period.</param>
        public DomainPublicAdapterWebApiModelsV1ListingsStatisticsReport(DomainPublicAdapterWebApiModelsV1ListingsStatistics summary = default(DomainPublicAdapterWebApiModelsV1ListingsStatistics), List<DomainPublicAdapterWebApiModelsV1ListingsStatistics> dailyBreakdown = default(List<DomainPublicAdapterWebApiModelsV1ListingsStatistics>))
        {
            this.Summary = summary;
            this.DailyBreakdown = dailyBreakdown;
        }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public DomainPublicAdapterWebApiModelsV1ListingsStatistics Summary { get; set; }

        /// <summary>
        /// Listing statistic breakdown for the period
        /// </summary>
        /// <value>Listing statistic breakdown for the period</value>
        [DataMember(Name = "dailyBreakdown", EmitDefaultValue = false)]
        public List<DomainPublicAdapterWebApiModelsV1ListingsStatistics> DailyBreakdown { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainPublicAdapterWebApiModelsV1ListingsStatisticsReport {\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  DailyBreakdown: ").Append(DailyBreakdown).Append("\n");
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
            return this.Equals(input as DomainPublicAdapterWebApiModelsV1ListingsStatisticsReport);
        }

        /// <summary>
        /// Returns true if DomainPublicAdapterWebApiModelsV1ListingsStatisticsReport instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainPublicAdapterWebApiModelsV1ListingsStatisticsReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainPublicAdapterWebApiModelsV1ListingsStatisticsReport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.DailyBreakdown == input.DailyBreakdown ||
                    this.DailyBreakdown != null &&
                    input.DailyBreakdown != null &&
                    this.DailyBreakdown.SequenceEqual(input.DailyBreakdown)
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
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.DailyBreakdown != null)
                    hashCode = hashCode * 59 + this.DailyBreakdown.GetHashCode();
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
