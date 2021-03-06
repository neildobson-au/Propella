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
    /// DomainAgencyServiceV2ModelAgencyOptions
    /// </summary>
    [DataContract(Name = "Domain.AgencyService.v2.Model.AgencyOptions")]
    public partial class DomainAgencyServiceV2ModelAgencyOptions : IEquatable<DomainAgencyServiceV2ModelAgencyOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainAgencyServiceV2ModelAgencyOptions" /> class.
        /// </summary>
        /// <param name="saleListingsGstOption">saleListingsGstOption.</param>
        /// <param name="leaseListingsGstOption">leaseListingsGstOption.</param>
        /// <param name="receiveLookForPropertyRequests">receiveLookForPropertyRequests.</param>
        /// <param name="receiveSellPropertyRequests">receiveSellPropertyRequests.</param>
        /// <param name="receivePropertyValuationRequests">receivePropertyValuationRequests.</param>
        /// <param name="agentDirectoryListing">agentDirectoryListing.</param>
        public DomainAgencyServiceV2ModelAgencyOptions(int saleListingsGstOption = default(int), int leaseListingsGstOption = default(int), bool receiveLookForPropertyRequests = default(bool), bool receiveSellPropertyRequests = default(bool), bool receivePropertyValuationRequests = default(bool), bool agentDirectoryListing = default(bool))
        {
            this.SaleListingsGstOption = saleListingsGstOption;
            this.LeaseListingsGstOption = leaseListingsGstOption;
            this.ReceiveLookForPropertyRequests = receiveLookForPropertyRequests;
            this.ReceiveSellPropertyRequests = receiveSellPropertyRequests;
            this.ReceivePropertyValuationRequests = receivePropertyValuationRequests;
            this.AgentDirectoryListing = agentDirectoryListing;
        }

        /// <summary>
        /// Gets or Sets SaleListingsGstOption
        /// </summary>
        [DataMember(Name = "saleListingsGstOption", EmitDefaultValue = false)]
        public int SaleListingsGstOption { get; set; }

        /// <summary>
        /// Gets or Sets LeaseListingsGstOption
        /// </summary>
        [DataMember(Name = "leaseListingsGstOption", EmitDefaultValue = false)]
        public int LeaseListingsGstOption { get; set; }

        /// <summary>
        /// Gets or Sets ReceiveLookForPropertyRequests
        /// </summary>
        [DataMember(Name = "receiveLookForPropertyRequests", EmitDefaultValue = false)]
        public bool ReceiveLookForPropertyRequests { get; set; }

        /// <summary>
        /// Gets or Sets ReceiveSellPropertyRequests
        /// </summary>
        [DataMember(Name = "receiveSellPropertyRequests", EmitDefaultValue = false)]
        public bool ReceiveSellPropertyRequests { get; set; }

        /// <summary>
        /// Gets or Sets ReceivePropertyValuationRequests
        /// </summary>
        [DataMember(Name = "receivePropertyValuationRequests", EmitDefaultValue = false)]
        public bool ReceivePropertyValuationRequests { get; set; }

        /// <summary>
        /// Gets or Sets AgentDirectoryListing
        /// </summary>
        [DataMember(Name = "agentDirectoryListing", EmitDefaultValue = false)]
        public bool AgentDirectoryListing { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainAgencyServiceV2ModelAgencyOptions {\n");
            sb.Append("  SaleListingsGstOption: ").Append(SaleListingsGstOption).Append("\n");
            sb.Append("  LeaseListingsGstOption: ").Append(LeaseListingsGstOption).Append("\n");
            sb.Append("  ReceiveLookForPropertyRequests: ").Append(ReceiveLookForPropertyRequests).Append("\n");
            sb.Append("  ReceiveSellPropertyRequests: ").Append(ReceiveSellPropertyRequests).Append("\n");
            sb.Append("  ReceivePropertyValuationRequests: ").Append(ReceivePropertyValuationRequests).Append("\n");
            sb.Append("  AgentDirectoryListing: ").Append(AgentDirectoryListing).Append("\n");
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
            return this.Equals(input as DomainAgencyServiceV2ModelAgencyOptions);
        }

        /// <summary>
        /// Returns true if DomainAgencyServiceV2ModelAgencyOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainAgencyServiceV2ModelAgencyOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainAgencyServiceV2ModelAgencyOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SaleListingsGstOption == input.SaleListingsGstOption ||
                    this.SaleListingsGstOption.Equals(input.SaleListingsGstOption)
                ) && 
                (
                    this.LeaseListingsGstOption == input.LeaseListingsGstOption ||
                    this.LeaseListingsGstOption.Equals(input.LeaseListingsGstOption)
                ) && 
                (
                    this.ReceiveLookForPropertyRequests == input.ReceiveLookForPropertyRequests ||
                    this.ReceiveLookForPropertyRequests.Equals(input.ReceiveLookForPropertyRequests)
                ) && 
                (
                    this.ReceiveSellPropertyRequests == input.ReceiveSellPropertyRequests ||
                    this.ReceiveSellPropertyRequests.Equals(input.ReceiveSellPropertyRequests)
                ) && 
                (
                    this.ReceivePropertyValuationRequests == input.ReceivePropertyValuationRequests ||
                    this.ReceivePropertyValuationRequests.Equals(input.ReceivePropertyValuationRequests)
                ) && 
                (
                    this.AgentDirectoryListing == input.AgentDirectoryListing ||
                    this.AgentDirectoryListing.Equals(input.AgentDirectoryListing)
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
                hashCode = hashCode * 59 + this.SaleListingsGstOption.GetHashCode();
                hashCode = hashCode * 59 + this.LeaseListingsGstOption.GetHashCode();
                hashCode = hashCode * 59 + this.ReceiveLookForPropertyRequests.GetHashCode();
                hashCode = hashCode * 59 + this.ReceiveSellPropertyRequests.GetHashCode();
                hashCode = hashCode * 59 + this.ReceivePropertyValuationRequests.GetHashCode();
                hashCode = hashCode * 59 + this.AgentDirectoryListing.GetHashCode();
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
