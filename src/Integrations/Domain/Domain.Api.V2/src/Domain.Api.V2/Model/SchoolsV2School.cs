/*
 * Domain Public API
 *
 * See https://developer.domain.com.au for more information
 *
 * The version of the OpenAPI document: v2
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
using OpenAPIDateConverter = Domain.Api.V2.Client.OpenAPIDateConverter;

namespace Domain.Api.V2.Model
{
    /// <summary>
    /// SchoolsV2School
    /// </summary>
    [DataContract(Name = "Schools.V2.School")]
    public partial class SchoolsV2School : IEquatable<SchoolsV2School>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolsV2School" /> class.
        /// </summary>
        /// <param name="profile">profile.</param>
        public SchoolsV2School(SchoolsV2SchoolProfile profile = default(SchoolsV2SchoolProfile))
        {
            this.Profile = profile;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return false;
        }

        /// <summary>
        /// Gets possible values include: &#39;Catholic&#39;, &#39;Government&#39;,  &#39;Independent&#39;
        /// </summary>
        /// <value>Gets possible values include: &#39;Catholic&#39;, &#39;Government&#39;,  &#39;Independent&#39;</value>
        [DataMember(Name = "schoolSector", EmitDefaultValue = true)]
        public string SchoolSector { get; private set; }

        /// <summary>
        /// Returns false as SchoolSector should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSchoolSector()
        {
            return false;
        }

        /// <summary>
        /// Gets possible values include: &#39;Combined&#39;, &#39;Primary&#39;, &#39;Secondary&#39;,  &#39;Special&#39;
        /// </summary>
        /// <value>Gets possible values include: &#39;Combined&#39;, &#39;Primary&#39;, &#39;Secondary&#39;,  &#39;Special&#39;</value>
        [DataMember(Name = "schoolType", EmitDefaultValue = true)]
        public string SchoolType { get; private set; }

        /// <summary>
        /// Returns false as SchoolType should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSchoolType()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Suburb
        /// </summary>
        [DataMember(Name = "suburb", EmitDefaultValue = true)]
        public string Suburb { get; private set; }

        /// <summary>
        /// Returns false as Suburb should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSuburb()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = true)]
        public string State { get; private set; }

        /// <summary>
        /// Returns false as State should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeState()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Postcode
        /// </summary>
        [DataMember(Name = "postcode", EmitDefaultValue = true)]
        public string Postcode { get; private set; }

        /// <summary>
        /// Returns false as Postcode should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePostcode()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Centroid
        /// </summary>
        [DataMember(Name = "centroid", EmitDefaultValue = true)]
        public string Centroid { get; private set; }

        /// <summary>
        /// Returns false as Centroid should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCentroid()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Profile
        /// </summary>
        [DataMember(Name = "profile", EmitDefaultValue = false)]
        public SchoolsV2SchoolProfile Profile { get; set; }

        /// <summary>
        /// Gets or Sets Catchments
        /// </summary>
        [DataMember(Name = "catchments", EmitDefaultValue = true)]
        public List<SchoolsV2SchoolCatchment> Catchments { get; private set; }

        /// <summary>
        /// Returns false as Catchments should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCatchments()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets DomainId
        /// </summary>
        [DataMember(Name = "domainId", EmitDefaultValue = true)]
        public int? DomainId { get; private set; }

        /// <summary>
        /// Returns false as DomainId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDomainId()
        {
            return false;
        }

        /// <summary>
        /// Gets possible values include: &#39;Boys&#39;, &#39;Girls&#39;, &#39;CoEd&#39;
        /// </summary>
        /// <value>Gets possible values include: &#39;Boys&#39;, &#39;Girls&#39;, &#39;CoEd&#39;</value>
        [DataMember(Name = "gender", EmitDefaultValue = true)]
        public string Gender { get; private set; }

        /// <summary>
        /// Returns false as Gender should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeGender()
        {
            return false;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchoolsV2School {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SchoolSector: ").Append(SchoolSector).Append("\n");
            sb.Append("  SchoolType: ").Append(SchoolType).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  Centroid: ").Append(Centroid).Append("\n");
            sb.Append("  Profile: ").Append(Profile).Append("\n");
            sb.Append("  Catchments: ").Append(Catchments).Append("\n");
            sb.Append("  DomainId: ").Append(DomainId).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
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
            return this.Equals(input as SchoolsV2School);
        }

        /// <summary>
        /// Returns true if SchoolsV2School instances are equal
        /// </summary>
        /// <param name="input">Instance of SchoolsV2School to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchoolsV2School input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SchoolSector == input.SchoolSector ||
                    (this.SchoolSector != null &&
                    this.SchoolSector.Equals(input.SchoolSector))
                ) && 
                (
                    this.SchoolType == input.SchoolType ||
                    (this.SchoolType != null &&
                    this.SchoolType.Equals(input.SchoolType))
                ) && 
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
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                    this.Postcode.Equals(input.Postcode))
                ) && 
                (
                    this.Centroid == input.Centroid ||
                    (this.Centroid != null &&
                    this.Centroid.Equals(input.Centroid))
                ) && 
                (
                    this.Profile == input.Profile ||
                    (this.Profile != null &&
                    this.Profile.Equals(input.Profile))
                ) && 
                (
                    this.Catchments == input.Catchments ||
                    this.Catchments != null &&
                    input.Catchments != null &&
                    this.Catchments.SequenceEqual(input.Catchments)
                ) && 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SchoolSector != null)
                    hashCode = hashCode * 59 + this.SchoolSector.GetHashCode();
                if (this.SchoolType != null)
                    hashCode = hashCode * 59 + this.SchoolType.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                if (this.Centroid != null)
                    hashCode = hashCode * 59 + this.Centroid.GetHashCode();
                if (this.Profile != null)
                    hashCode = hashCode * 59 + this.Profile.GetHashCode();
                if (this.Catchments != null)
                    hashCode = hashCode * 59 + this.Catchments.GetHashCode();
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Gender != null)
                    hashCode = hashCode * 59 + this.Gender.GetHashCode();
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
