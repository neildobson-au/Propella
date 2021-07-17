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
    /// Represent the listing job.
    /// </summary>
    [DataContract(Name = "Domain.ListingAdminService.v1.Model.ListingResponse")]
    public partial class DomainListingAdminServiceV1ModelListingResponse : IEquatable<DomainListingAdminServiceV1ModelListingResponse>, IValidatableObject
    {
        /// <summary>
        /// Status of listing been processed
        /// </summary>
        /// <value>Status of listing been processed</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProcessStatusEnum
        {
            /// <summary>
            /// Enum Queued for value: queued
            /// </summary>
            [EnumMember(Value = "queued")]
            Queued = 1,

            /// <summary>
            /// Enum Processing for value: processing
            /// </summary>
            [EnumMember(Value = "processing")]
            Processing = 2,

            /// <summary>
            /// Enum Processed for value: processed
            /// </summary>
            [EnumMember(Value = "processed")]
            Processed = 3,

            /// <summary>
            /// Enum Searchable for value: searchable
            /// </summary>
            [EnumMember(Value = "searchable")]
            Searchable = 4,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 5,

            /// <summary>
            /// Enum Error for value: error
            /// </summary>
            [EnumMember(Value = "error")]
            Error = 6

        }

        /// <summary>
        /// Status of listing been processed
        /// </summary>
        /// <value>Status of listing been processed</value>
        [DataMember(Name = "processStatus", EmitDefaultValue = false)]
        public ProcessStatusEnum? ProcessStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainListingAdminServiceV1ModelListingResponse" /> class.
        /// </summary>
        /// <param name="processStatus">Status of listing been processed.</param>
        /// <param name="id">The listing job Id.   This job will eventually be processed..</param>
        /// <param name="agencyId">Agency Id from Domain..</param>
        /// <param name="providerId">Provider Id for the agency..</param>
        /// <param name="providerAdId">Listing identifier provided by CRM..</param>
        /// <param name="versionId">Version Id.</param>
        public DomainListingAdminServiceV1ModelListingResponse(ProcessStatusEnum? processStatus = default(ProcessStatusEnum?), string id = default(string), int agencyId = default(int), string providerId = default(string), string providerAdId = default(string), string versionId = default(string))
        {
            this.ProcessStatus = processStatus;
            this.Id = id;
            this.AgencyId = agencyId;
            this.ProviderId = providerId;
            this.ProviderAdId = providerAdId;
            this.VersionId = versionId;
        }

        /// <summary>
        /// The listing job Id.   This job will eventually be processed.
        /// </summary>
        /// <value>The listing job Id.   This job will eventually be processed.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Agency Id from Domain.
        /// </summary>
        /// <value>Agency Id from Domain.</value>
        [DataMember(Name = "agencyId", EmitDefaultValue = false)]
        public int AgencyId { get; set; }

        /// <summary>
        /// Provider Id for the agency.
        /// </summary>
        /// <value>Provider Id for the agency.</value>
        [DataMember(Name = "providerId", EmitDefaultValue = false)]
        public string ProviderId { get; set; }

        /// <summary>
        /// Listing identifier provided by CRM.
        /// </summary>
        /// <value>Listing identifier provided by CRM.</value>
        [DataMember(Name = "providerAdId", EmitDefaultValue = false)]
        public string ProviderAdId { get; set; }

        /// <summary>
        /// Version Id
        /// </summary>
        /// <value>Version Id</value>
        [DataMember(Name = "versionId", EmitDefaultValue = false)]
        public string VersionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainListingAdminServiceV1ModelListingResponse {\n");
            sb.Append("  ProcessStatus: ").Append(ProcessStatus).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AgencyId: ").Append(AgencyId).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  ProviderAdId: ").Append(ProviderAdId).Append("\n");
            sb.Append("  VersionId: ").Append(VersionId).Append("\n");
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
            return this.Equals(input as DomainListingAdminServiceV1ModelListingResponse);
        }

        /// <summary>
        /// Returns true if DomainListingAdminServiceV1ModelListingResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainListingAdminServiceV1ModelListingResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainListingAdminServiceV1ModelListingResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProcessStatus == input.ProcessStatus ||
                    this.ProcessStatus.Equals(input.ProcessStatus)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.AgencyId == input.AgencyId ||
                    this.AgencyId.Equals(input.AgencyId)
                ) && 
                (
                    this.ProviderId == input.ProviderId ||
                    (this.ProviderId != null &&
                    this.ProviderId.Equals(input.ProviderId))
                ) && 
                (
                    this.ProviderAdId == input.ProviderAdId ||
                    (this.ProviderAdId != null &&
                    this.ProviderAdId.Equals(input.ProviderAdId))
                ) && 
                (
                    this.VersionId == input.VersionId ||
                    (this.VersionId != null &&
                    this.VersionId.Equals(input.VersionId))
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
                hashCode = hashCode * 59 + this.ProcessStatus.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                hashCode = hashCode * 59 + this.AgencyId.GetHashCode();
                if (this.ProviderId != null)
                    hashCode = hashCode * 59 + this.ProviderId.GetHashCode();
                if (this.ProviderAdId != null)
                    hashCode = hashCode * 59 + this.ProviderAdId.GetHashCode();
                if (this.VersionId != null)
                    hashCode = hashCode * 59 + this.VersionId.GetHashCode();
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