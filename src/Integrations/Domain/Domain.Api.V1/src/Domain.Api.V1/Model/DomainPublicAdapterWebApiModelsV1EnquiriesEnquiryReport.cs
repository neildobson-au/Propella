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
    /// An enquiry with delivery status information
    /// </summary>
    [DataContract(Name = "Domain.Public.Adapter.Web.Api.Models.v1.Enquiries.EnquiryReport")]
    public partial class DomainPublicAdapterWebApiModelsV1EnquiriesEnquiryReport : IEquatable<DomainPublicAdapterWebApiModelsV1EnquiriesEnquiryReport>, IValidatableObject
    {
        /// <summary>
        /// Delivery method of the enquiry
        /// </summary>
        /// <value>Delivery method of the enquiry</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeliveryMethodEnum
        {
            /// <summary>
            /// Enum Email for value: email
            /// </summary>
            [EnumMember(Value = "email")]
            Email = 1,

            /// <summary>
            /// Enum Sms for value: sms
            /// </summary>
            [EnumMember(Value = "sms")]
            Sms = 2

        }

        /// <summary>
        /// Delivery method of the enquiry
        /// </summary>
        /// <value>Delivery method of the enquiry</value>
        [DataMember(Name = "deliveryMethod", EmitDefaultValue = false)]
        public DeliveryMethodEnum? DeliveryMethod { get; set; }
        /// <summary>
        /// Type of enquiry
        /// </summary>
        /// <value>Type of enquiry</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EnquiryTypeEnum
        {
            /// <summary>
            /// Enum Listing for value: listing
            /// </summary>
            [EnumMember(Value = "listing")]
            Listing = 1,

            /// <summary>
            /// Enum DevProject for value: devProject
            /// </summary>
            [EnumMember(Value = "devProject")]
            DevProject = 2,

            /// <summary>
            /// Enum NewDevLanding for value: newDevLanding
            /// </summary>
            [EnumMember(Value = "newDevLanding")]
            NewDevLanding = 3,

            /// <summary>
            /// Enum AgencyProfile for value: agencyProfile
            /// </summary>
            [EnumMember(Value = "agencyProfile")]
            AgencyProfile = 4,

            /// <summary>
            /// Enum AgentProfile for value: agentProfile
            /// </summary>
            [EnumMember(Value = "agentProfile")]
            AgentProfile = 5,

            /// <summary>
            /// Enum ContractRequest for value: contractRequest
            /// </summary>
            [EnumMember(Value = "contractRequest")]
            ContractRequest = 6,

            /// <summary>
            /// Enum VendorEnquiry for value: vendorEnquiry
            /// </summary>
            [EnumMember(Value = "vendorEnquiry")]
            VendorEnquiry = 7,

            /// <summary>
            /// Enum PrePortalListing for value: prePortalListing
            /// </summary>
            [EnumMember(Value = "prePortalListing")]
            PrePortalListing = 8

        }

        /// <summary>
        /// Type of enquiry
        /// </summary>
        /// <value>Type of enquiry</value>
        [DataMember(Name = "enquiryType", EmitDefaultValue = false)]
        public EnquiryTypeEnum? EnquiryType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainPublicAdapterWebApiModelsV1EnquiriesEnquiryReport" /> class.
        /// </summary>
        /// <param name="recipientsDeliveryStatus">Recipients of the delivery.</param>
        /// <param name="deliveryMethod">Delivery method of the enquiry.</param>
        /// <param name="enquiryType">Type of enquiry.</param>
        /// <param name="referenceId">Listing identifier.</param>
        /// <param name="id">Enquiry identifier.</param>
        /// <param name="sender">sender.</param>
        /// <param name="subject">Enquiry subject.</param>
        /// <param name="message">Enquiry message.</param>
        /// <param name="metaData">MetaData of the enquiry.</param>
        public DomainPublicAdapterWebApiModelsV1EnquiriesEnquiryReport(List<DomainPublicAdapterWebApiModelsV1EnquiriesRecipientDeliveryStatus> recipientsDeliveryStatus = default(List<DomainPublicAdapterWebApiModelsV1EnquiriesRecipientDeliveryStatus>), DeliveryMethodEnum? deliveryMethod = default(DeliveryMethodEnum?), EnquiryTypeEnum? enquiryType = default(EnquiryTypeEnum?), int referenceId = default(int), string id = default(string), DomainPublicAdapterWebApiModelsV1EnquiriesSender sender = default(DomainPublicAdapterWebApiModelsV1EnquiriesSender), string subject = default(string), string message = default(string), Dictionary<string, string> metaData = default(Dictionary<string, string>))
        {
            this.RecipientsDeliveryStatus = recipientsDeliveryStatus;
            this.DeliveryMethod = deliveryMethod;
            this.EnquiryType = enquiryType;
            this.ReferenceId = referenceId;
            this.Id = id;
            this.Sender = sender;
            this.Subject = subject;
            this.Message = message;
            this.MetaData = metaData;
        }

        /// <summary>
        /// Recipients of the delivery
        /// </summary>
        /// <value>Recipients of the delivery</value>
        [DataMember(Name = "recipientsDeliveryStatus", EmitDefaultValue = false)]
        public List<DomainPublicAdapterWebApiModelsV1EnquiriesRecipientDeliveryStatus> RecipientsDeliveryStatus { get; set; }

        /// <summary>
        /// Listing identifier
        /// </summary>
        /// <value>Listing identifier</value>
        [DataMember(Name = "referenceId", EmitDefaultValue = false)]
        public int ReferenceId { get; set; }

        /// <summary>
        /// Enquiry identifier
        /// </summary>
        /// <value>Enquiry identifier</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name = "sender", EmitDefaultValue = false)]
        public DomainPublicAdapterWebApiModelsV1EnquiriesSender Sender { get; set; }

        /// <summary>
        /// Enquiry subject
        /// </summary>
        /// <value>Enquiry subject</value>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Enquiry message
        /// </summary>
        /// <value>Enquiry message</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// MetaData of the enquiry
        /// </summary>
        /// <value>MetaData of the enquiry</value>
        [DataMember(Name = "metaData", EmitDefaultValue = false)]
        public Dictionary<string, string> MetaData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainPublicAdapterWebApiModelsV1EnquiriesEnquiryReport {\n");
            sb.Append("  RecipientsDeliveryStatus: ").Append(RecipientsDeliveryStatus).Append("\n");
            sb.Append("  DeliveryMethod: ").Append(DeliveryMethod).Append("\n");
            sb.Append("  EnquiryType: ").Append(EnquiryType).Append("\n");
            sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
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
            return this.Equals(input as DomainPublicAdapterWebApiModelsV1EnquiriesEnquiryReport);
        }

        /// <summary>
        /// Returns true if DomainPublicAdapterWebApiModelsV1EnquiriesEnquiryReport instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainPublicAdapterWebApiModelsV1EnquiriesEnquiryReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainPublicAdapterWebApiModelsV1EnquiriesEnquiryReport input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RecipientsDeliveryStatus == input.RecipientsDeliveryStatus ||
                    this.RecipientsDeliveryStatus != null &&
                    input.RecipientsDeliveryStatus != null &&
                    this.RecipientsDeliveryStatus.SequenceEqual(input.RecipientsDeliveryStatus)
                ) && 
                (
                    this.DeliveryMethod == input.DeliveryMethod ||
                    this.DeliveryMethod.Equals(input.DeliveryMethod)
                ) && 
                (
                    this.EnquiryType == input.EnquiryType ||
                    this.EnquiryType.Equals(input.EnquiryType)
                ) && 
                (
                    this.ReferenceId == input.ReferenceId ||
                    this.ReferenceId.Equals(input.ReferenceId)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.MetaData == input.MetaData ||
                    this.MetaData != null &&
                    input.MetaData != null &&
                    this.MetaData.SequenceEqual(input.MetaData)
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
                if (this.RecipientsDeliveryStatus != null)
                    hashCode = hashCode * 59 + this.RecipientsDeliveryStatus.GetHashCode();
                hashCode = hashCode * 59 + this.DeliveryMethod.GetHashCode();
                hashCode = hashCode * 59 + this.EnquiryType.GetHashCode();
                hashCode = hashCode * 59 + this.ReferenceId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.MetaData != null)
                    hashCode = hashCode * 59 + this.MetaData.GetHashCode();
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
