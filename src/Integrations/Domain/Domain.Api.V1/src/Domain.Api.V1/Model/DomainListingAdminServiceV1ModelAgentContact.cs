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
    /// Represents a agent or conjunction agent domain model  The only difference to normal contacts is agent contacts needs to have their agency specified
    /// </summary>
    [DataContract(Name = "Domain.ListingAdminService.v1.Model.AgentContact")]
    public partial class DomainListingAdminServiceV1ModelAgentContact : IEquatable<DomainListingAdminServiceV1ModelAgentContact>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainListingAdminServiceV1ModelAgentContact" /> class.
        /// </summary>
        /// <param name="agencyId">Conjunction agent&#39;s agency.</param>
        /// <param name="domainAgentId">Domain ID of the contact person at the agency.</param>
        /// <param name="firstName">First name. Maximum 50 characters..</param>
        /// <param name="lastName">Last name. Maximum 50 characters..</param>
        /// <param name="phone">Phone. Maximum 20 characters..</param>
        /// <param name="fax">Fax. Maximum 20 characters..</param>
        /// <param name="mobile">Mobile. Maximum 20 characters..</param>
        /// <param name="email">Email. Maximum 100 characters..</param>
        /// <param name="receiveEmails">Indicates whether the contact person should receive emails for the listing.</param>
        public DomainListingAdminServiceV1ModelAgentContact(int agencyId = default(int), int domainAgentId = default(int), string firstName = default(string), string lastName = default(string), string phone = default(string), string fax = default(string), string mobile = default(string), string email = default(string), bool receiveEmails = default(bool))
        {
            this.AgencyId = agencyId;
            this.DomainAgentId = domainAgentId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Fax = fax;
            this.Mobile = mobile;
            this.Email = email;
            this.ReceiveEmails = receiveEmails;
        }

        /// <summary>
        /// Conjunction agent&#39;s agency
        /// </summary>
        /// <value>Conjunction agent&#39;s agency</value>
        [DataMember(Name = "agencyId", EmitDefaultValue = false)]
        public int AgencyId { get; set; }

        /// <summary>
        /// Domain ID of the contact person at the agency
        /// </summary>
        /// <value>Domain ID of the contact person at the agency</value>
        [DataMember(Name = "domainAgentId", EmitDefaultValue = false)]
        public int DomainAgentId { get; set; }

        /// <summary>
        /// First name. Maximum 50 characters.
        /// </summary>
        /// <value>First name. Maximum 50 characters.</value>
        [DataMember(Name = "firstName", EmitDefaultValue = false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name. Maximum 50 characters.
        /// </summary>
        /// <value>Last name. Maximum 50 characters.</value>
        [DataMember(Name = "lastName", EmitDefaultValue = false)]
        public string LastName { get; set; }

        /// <summary>
        /// Phone. Maximum 20 characters.
        /// </summary>
        /// <value>Phone. Maximum 20 characters.</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Fax. Maximum 20 characters.
        /// </summary>
        /// <value>Fax. Maximum 20 characters.</value>
        [DataMember(Name = "fax", EmitDefaultValue = false)]
        public string Fax { get; set; }

        /// <summary>
        /// Mobile. Maximum 20 characters.
        /// </summary>
        /// <value>Mobile. Maximum 20 characters.</value>
        [DataMember(Name = "mobile", EmitDefaultValue = false)]
        public string Mobile { get; set; }

        /// <summary>
        /// Email. Maximum 100 characters.
        /// </summary>
        /// <value>Email. Maximum 100 characters.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Indicates whether the contact person should receive emails for the listing
        /// </summary>
        /// <value>Indicates whether the contact person should receive emails for the listing</value>
        [DataMember(Name = "receiveEmails", EmitDefaultValue = false)]
        public bool ReceiveEmails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainListingAdminServiceV1ModelAgentContact {\n");
            sb.Append("  AgencyId: ").Append(AgencyId).Append("\n");
            sb.Append("  DomainAgentId: ").Append(DomainAgentId).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  ReceiveEmails: ").Append(ReceiveEmails).Append("\n");
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
            return this.Equals(input as DomainListingAdminServiceV1ModelAgentContact);
        }

        /// <summary>
        /// Returns true if DomainListingAdminServiceV1ModelAgentContact instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainListingAdminServiceV1ModelAgentContact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainListingAdminServiceV1ModelAgentContact input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AgencyId == input.AgencyId ||
                    this.AgencyId.Equals(input.AgencyId)
                ) && 
                (
                    this.DomainAgentId == input.DomainAgentId ||
                    this.DomainAgentId.Equals(input.DomainAgentId)
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Fax == input.Fax ||
                    (this.Fax != null &&
                    this.Fax.Equals(input.Fax))
                ) && 
                (
                    this.Mobile == input.Mobile ||
                    (this.Mobile != null &&
                    this.Mobile.Equals(input.Mobile))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.ReceiveEmails == input.ReceiveEmails ||
                    this.ReceiveEmails.Equals(input.ReceiveEmails)
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
                hashCode = hashCode * 59 + this.AgencyId.GetHashCode();
                hashCode = hashCode * 59 + this.DomainAgentId.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Fax != null)
                    hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.Mobile != null)
                    hashCode = hashCode * 59 + this.Mobile.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                hashCode = hashCode * 59 + this.ReceiveEmails.GetHashCode();
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
