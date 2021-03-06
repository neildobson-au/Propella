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
    /// Used for reporting enquiry delivery statusses to recipients
    /// </summary>
    [DataContract(Name = "Domain.Public.Adapter.Web.Api.Models.v1.Enquiries.RecipientDeliveryStatus")]
    public partial class DomainPublicAdapterWebApiModelsV1EnquiriesRecipientDeliveryStatus : IEquatable<DomainPublicAdapterWebApiModelsV1EnquiriesRecipientDeliveryStatus>, IValidatableObject
    {
        /// <summary>
        /// Delivery status of the enquiry for the recipient
        /// </summary>
        /// <value>Delivery status of the enquiry for the recipient</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeliveryStatusEnum
        {
            /// <summary>
            /// Enum Queued for value: queued
            /// </summary>
            [EnumMember(Value = "queued")]
            Queued = 1,

            /// <summary>
            /// Enum Delivered for value: delivered
            /// </summary>
            [EnumMember(Value = "delivered")]
            Delivered = 2,

            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            [EnumMember(Value = "failed")]
            Failed = 3

        }

        /// <summary>
        /// Delivery status of the enquiry for the recipient
        /// </summary>
        /// <value>Delivery status of the enquiry for the recipient</value>
        [DataMember(Name = "deliveryStatus", EmitDefaultValue = false)]
        public DeliveryStatusEnum? DeliveryStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainPublicAdapterWebApiModelsV1EnquiriesRecipientDeliveryStatus" /> class.
        /// </summary>
        /// <param name="deliveryStatus">Delivery status of the enquiry for the recipient.</param>
        /// <param name="recipient">recipient.</param>
        /// <param name="date">Date of the Action. Delivery or failure.</param>
        public DomainPublicAdapterWebApiModelsV1EnquiriesRecipientDeliveryStatus(DeliveryStatusEnum? deliveryStatus = default(DeliveryStatusEnum?), DomainPublicAdapterWebApiModelsV1EnquiriesRecipient recipient = default(DomainPublicAdapterWebApiModelsV1EnquiriesRecipient), DateTime date = default(DateTime))
        {
            this.DeliveryStatus = deliveryStatus;
            this.Recipient = recipient;
            this.Date = date;
        }

        /// <summary>
        /// Gets or Sets Recipient
        /// </summary>
        [DataMember(Name = "recipient", EmitDefaultValue = false)]
        public DomainPublicAdapterWebApiModelsV1EnquiriesRecipient Recipient { get; set; }

        /// <summary>
        /// Date of the Action. Delivery or failure
        /// </summary>
        /// <value>Date of the Action. Delivery or failure</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainPublicAdapterWebApiModelsV1EnquiriesRecipientDeliveryStatus {\n");
            sb.Append("  DeliveryStatus: ").Append(DeliveryStatus).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
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
            return this.Equals(input as DomainPublicAdapterWebApiModelsV1EnquiriesRecipientDeliveryStatus);
        }

        /// <summary>
        /// Returns true if DomainPublicAdapterWebApiModelsV1EnquiriesRecipientDeliveryStatus instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainPublicAdapterWebApiModelsV1EnquiriesRecipientDeliveryStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainPublicAdapterWebApiModelsV1EnquiriesRecipientDeliveryStatus input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeliveryStatus == input.DeliveryStatus ||
                    this.DeliveryStatus.Equals(input.DeliveryStatus)
                ) && 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
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
                hashCode = hashCode * 59 + this.DeliveryStatus.GetHashCode();
                if (this.Recipient != null)
                    hashCode = hashCode * 59 + this.Recipient.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
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
