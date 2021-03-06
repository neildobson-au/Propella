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
    /// DomainEnquiryServiceV1ModelGroupEnquiryServiceModelsEnquiryResponse
    /// </summary>
    [DataContract(Name = "Domain.EnquiryService.v1.Model.GroupEnquiryServiceModelsEnquiryResponse")]
    public partial class DomainEnquiryServiceV1ModelGroupEnquiryServiceModelsEnquiryResponse : IEquatable<DomainEnquiryServiceV1ModelGroupEnquiryServiceModelsEnquiryResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainEnquiryServiceV1ModelGroupEnquiryServiceModelsEnquiryResponse" /> class.
        /// </summary>
        /// <param name="s3Key">s3Key.</param>
        /// <param name="message">message.</param>
        /// <param name="enquiryReceiptTimestamp">enquiryReceiptTimestamp.</param>
        /// <param name="warnings">warnings.</param>
        public DomainEnquiryServiceV1ModelGroupEnquiryServiceModelsEnquiryResponse(string s3Key = default(string), string message = default(string), DateTime enquiryReceiptTimestamp = default(DateTime), List<string> warnings = default(List<string>))
        {
            this.S3Key = s3Key;
            this.Message = message;
            this.EnquiryReceiptTimestamp = enquiryReceiptTimestamp;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Gets or Sets S3Key
        /// </summary>
        [DataMember(Name = "s3Key", EmitDefaultValue = false)]
        public string S3Key { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets EnquiryReceiptTimestamp
        /// </summary>
        [DataMember(Name = "enquiryReceiptTimestamp", EmitDefaultValue = false)]
        public DateTime EnquiryReceiptTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets Warnings
        /// </summary>
        [DataMember(Name = "warnings", EmitDefaultValue = false)]
        public List<string> Warnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainEnquiryServiceV1ModelGroupEnquiryServiceModelsEnquiryResponse {\n");
            sb.Append("  S3Key: ").Append(S3Key).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  EnquiryReceiptTimestamp: ").Append(EnquiryReceiptTimestamp).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
            return this.Equals(input as DomainEnquiryServiceV1ModelGroupEnquiryServiceModelsEnquiryResponse);
        }

        /// <summary>
        /// Returns true if DomainEnquiryServiceV1ModelGroupEnquiryServiceModelsEnquiryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainEnquiryServiceV1ModelGroupEnquiryServiceModelsEnquiryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainEnquiryServiceV1ModelGroupEnquiryServiceModelsEnquiryResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.S3Key == input.S3Key ||
                    (this.S3Key != null &&
                    this.S3Key.Equals(input.S3Key))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.EnquiryReceiptTimestamp == input.EnquiryReceiptTimestamp ||
                    (this.EnquiryReceiptTimestamp != null &&
                    this.EnquiryReceiptTimestamp.Equals(input.EnquiryReceiptTimestamp))
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
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
                if (this.S3Key != null)
                    hashCode = hashCode * 59 + this.S3Key.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.EnquiryReceiptTimestamp != null)
                    hashCode = hashCode * 59 + this.EnquiryReceiptTimestamp.GetHashCode();
                if (this.Warnings != null)
                    hashCode = hashCode * 59 + this.Warnings.GetHashCode();
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
