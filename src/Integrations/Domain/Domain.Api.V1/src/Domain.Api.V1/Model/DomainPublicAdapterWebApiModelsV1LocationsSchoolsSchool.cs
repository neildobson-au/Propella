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
    /// School
    /// </summary>
    [DataContract(Name = "Domain.Public.Adapter.Web.Api.Models.v1.Locations.Schools.School")]
    public partial class DomainPublicAdapterWebApiModelsV1LocationsSchoolsSchool : IEquatable<DomainPublicAdapterWebApiModelsV1LocationsSchoolsSchool>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainPublicAdapterWebApiModelsV1LocationsSchoolsSchool" /> class.
        /// </summary>
        /// <param name="id">School identifier.</param>
        /// <param name="name">School name.</param>
        /// <param name="type">School type.</param>
        /// <param name="state">State.</param>
        /// <param name="localGovernmentArea">Local government area.</param>
        /// <param name="district">District.</param>
        /// <param name="postcode">Postcode.</param>
        /// <param name="suburb">Suburb.</param>
        /// <param name="street">Street.</param>
        /// <param name="phone">Phone number.</param>
        /// <param name="fax">Fax number.</param>
        /// <param name="email">Email.</param>
        /// <param name="websiteUrl">Website.</param>
        /// <param name="crestUrl">School crest.</param>
        /// <param name="educationLevel">Education level.</param>
        /// <param name="gender">Gender.</param>
        /// <param name="lowYear">Lower year.</param>
        /// <param name="highYear">Upper year.</param>
        /// <param name="geolocation">geolocation.</param>
        /// <param name="distanceFromLocation">Distance from search location in metres.</param>
        public DomainPublicAdapterWebApiModelsV1LocationsSchoolsSchool(int id = default(int), string name = default(string), string type = default(string), string state = default(string), string localGovernmentArea = default(string), string district = default(string), string postcode = default(string), string suburb = default(string), string street = default(string), string phone = default(string), string fax = default(string), string email = default(string), string websiteUrl = default(string), string crestUrl = default(string), string educationLevel = default(string), string gender = default(string), string lowYear = default(string), string highYear = default(string), DomainPublicAdapterWebApiModelsV1Point geolocation = default(DomainPublicAdapterWebApiModelsV1Point), double distanceFromLocation = default(double))
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
            this.State = state;
            this.LocalGovernmentArea = localGovernmentArea;
            this.District = district;
            this.Postcode = postcode;
            this.Suburb = suburb;
            this.Street = street;
            this.Phone = phone;
            this.Fax = fax;
            this.Email = email;
            this.WebsiteUrl = websiteUrl;
            this.CrestUrl = crestUrl;
            this.EducationLevel = educationLevel;
            this.Gender = gender;
            this.LowYear = lowYear;
            this.HighYear = highYear;
            this.Geolocation = geolocation;
            this.DistanceFromLocation = distanceFromLocation;
        }

        /// <summary>
        /// School identifier
        /// </summary>
        /// <value>School identifier</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// School name
        /// </summary>
        /// <value>School name</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// School type
        /// </summary>
        /// <value>School type</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// State
        /// </summary>
        /// <value>State</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Local government area
        /// </summary>
        /// <value>Local government area</value>
        [DataMember(Name = "localGovernmentArea", EmitDefaultValue = false)]
        public string LocalGovernmentArea { get; set; }

        /// <summary>
        /// District
        /// </summary>
        /// <value>District</value>
        [DataMember(Name = "district", EmitDefaultValue = false)]
        public string District { get; set; }

        /// <summary>
        /// Postcode
        /// </summary>
        /// <value>Postcode</value>
        [DataMember(Name = "postcode", EmitDefaultValue = false)]
        public string Postcode { get; set; }

        /// <summary>
        /// Suburb
        /// </summary>
        /// <value>Suburb</value>
        [DataMember(Name = "suburb", EmitDefaultValue = false)]
        public string Suburb { get; set; }

        /// <summary>
        /// Street
        /// </summary>
        /// <value>Street</value>
        [DataMember(Name = "street", EmitDefaultValue = false)]
        public string Street { get; set; }

        /// <summary>
        /// Display address
        /// </summary>
        /// <value>Display address</value>
        [DataMember(Name = "displayAddress", EmitDefaultValue = false)]
        public string DisplayAddress { get; private set; }

        /// <summary>
        /// Returns false as DisplayAddress should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDisplayAddress()
        {
            return false;
        }

        /// <summary>
        /// Phone number
        /// </summary>
        /// <value>Phone number</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Fax number
        /// </summary>
        /// <value>Fax number</value>
        [DataMember(Name = "fax", EmitDefaultValue = false)]
        public string Fax { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        /// <value>Email</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Website
        /// </summary>
        /// <value>Website</value>
        [DataMember(Name = "websiteUrl", EmitDefaultValue = false)]
        public string WebsiteUrl { get; set; }

        /// <summary>
        /// School crest
        /// </summary>
        /// <value>School crest</value>
        [DataMember(Name = "crestUrl", EmitDefaultValue = false)]
        public string CrestUrl { get; set; }

        /// <summary>
        /// Education level
        /// </summary>
        /// <value>Education level</value>
        [DataMember(Name = "educationLevel", EmitDefaultValue = false)]
        public string EducationLevel { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        /// <value>Gender</value>
        [DataMember(Name = "gender", EmitDefaultValue = false)]
        public string Gender { get; set; }

        /// <summary>
        /// Lower year
        /// </summary>
        /// <value>Lower year</value>
        [DataMember(Name = "lowYear", EmitDefaultValue = false)]
        public string LowYear { get; set; }

        /// <summary>
        /// Upper year
        /// </summary>
        /// <value>Upper year</value>
        [DataMember(Name = "highYear", EmitDefaultValue = false)]
        public string HighYear { get; set; }

        /// <summary>
        /// Year diplay
        /// </summary>
        /// <value>Year diplay</value>
        [DataMember(Name = "displayYear", EmitDefaultValue = false)]
        public string DisplayYear { get; private set; }

        /// <summary>
        /// Returns false as DisplayYear should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDisplayYear()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Geolocation
        /// </summary>
        [DataMember(Name = "geolocation", EmitDefaultValue = false)]
        public DomainPublicAdapterWebApiModelsV1Point Geolocation { get; set; }

        /// <summary>
        /// Distance from search location in metres
        /// </summary>
        /// <value>Distance from search location in metres</value>
        [DataMember(Name = "distanceFromLocation", EmitDefaultValue = false)]
        public double DistanceFromLocation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainPublicAdapterWebApiModelsV1LocationsSchoolsSchool {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  LocalGovernmentArea: ").Append(LocalGovernmentArea).Append("\n");
            sb.Append("  District: ").Append(District).Append("\n");
            sb.Append("  Postcode: ").Append(Postcode).Append("\n");
            sb.Append("  Suburb: ").Append(Suburb).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  DisplayAddress: ").Append(DisplayAddress).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  WebsiteUrl: ").Append(WebsiteUrl).Append("\n");
            sb.Append("  CrestUrl: ").Append(CrestUrl).Append("\n");
            sb.Append("  EducationLevel: ").Append(EducationLevel).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  LowYear: ").Append(LowYear).Append("\n");
            sb.Append("  HighYear: ").Append(HighYear).Append("\n");
            sb.Append("  DisplayYear: ").Append(DisplayYear).Append("\n");
            sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
            sb.Append("  DistanceFromLocation: ").Append(DistanceFromLocation).Append("\n");
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
            return this.Equals(input as DomainPublicAdapterWebApiModelsV1LocationsSchoolsSchool);
        }

        /// <summary>
        /// Returns true if DomainPublicAdapterWebApiModelsV1LocationsSchoolsSchool instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainPublicAdapterWebApiModelsV1LocationsSchoolsSchool to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainPublicAdapterWebApiModelsV1LocationsSchoolsSchool input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.LocalGovernmentArea == input.LocalGovernmentArea ||
                    (this.LocalGovernmentArea != null &&
                    this.LocalGovernmentArea.Equals(input.LocalGovernmentArea))
                ) && 
                (
                    this.District == input.District ||
                    (this.District != null &&
                    this.District.Equals(input.District))
                ) && 
                (
                    this.Postcode == input.Postcode ||
                    (this.Postcode != null &&
                    this.Postcode.Equals(input.Postcode))
                ) && 
                (
                    this.Suburb == input.Suburb ||
                    (this.Suburb != null &&
                    this.Suburb.Equals(input.Suburb))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.DisplayAddress == input.DisplayAddress ||
                    (this.DisplayAddress != null &&
                    this.DisplayAddress.Equals(input.DisplayAddress))
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
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.WebsiteUrl == input.WebsiteUrl ||
                    (this.WebsiteUrl != null &&
                    this.WebsiteUrl.Equals(input.WebsiteUrl))
                ) && 
                (
                    this.CrestUrl == input.CrestUrl ||
                    (this.CrestUrl != null &&
                    this.CrestUrl.Equals(input.CrestUrl))
                ) && 
                (
                    this.EducationLevel == input.EducationLevel ||
                    (this.EducationLevel != null &&
                    this.EducationLevel.Equals(input.EducationLevel))
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.LowYear == input.LowYear ||
                    (this.LowYear != null &&
                    this.LowYear.Equals(input.LowYear))
                ) && 
                (
                    this.HighYear == input.HighYear ||
                    (this.HighYear != null &&
                    this.HighYear.Equals(input.HighYear))
                ) && 
                (
                    this.DisplayYear == input.DisplayYear ||
                    (this.DisplayYear != null &&
                    this.DisplayYear.Equals(input.DisplayYear))
                ) && 
                (
                    this.Geolocation == input.Geolocation ||
                    (this.Geolocation != null &&
                    this.Geolocation.Equals(input.Geolocation))
                ) && 
                (
                    this.DistanceFromLocation == input.DistanceFromLocation ||
                    this.DistanceFromLocation.Equals(input.DistanceFromLocation)
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.LocalGovernmentArea != null)
                    hashCode = hashCode * 59 + this.LocalGovernmentArea.GetHashCode();
                if (this.District != null)
                    hashCode = hashCode * 59 + this.District.GetHashCode();
                if (this.Postcode != null)
                    hashCode = hashCode * 59 + this.Postcode.GetHashCode();
                if (this.Suburb != null)
                    hashCode = hashCode * 59 + this.Suburb.GetHashCode();
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
                if (this.DisplayAddress != null)
                    hashCode = hashCode * 59 + this.DisplayAddress.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Fax != null)
                    hashCode = hashCode * 59 + this.Fax.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.WebsiteUrl != null)
                    hashCode = hashCode * 59 + this.WebsiteUrl.GetHashCode();
                if (this.CrestUrl != null)
                    hashCode = hashCode * 59 + this.CrestUrl.GetHashCode();
                if (this.EducationLevel != null)
                    hashCode = hashCode * 59 + this.EducationLevel.GetHashCode();
                if (this.Gender != null)
                    hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.LowYear != null)
                    hashCode = hashCode * 59 + this.LowYear.GetHashCode();
                if (this.HighYear != null)
                    hashCode = hashCode * 59 + this.HighYear.GetHashCode();
                if (this.DisplayYear != null)
                    hashCode = hashCode * 59 + this.DisplayYear.GetHashCode();
                if (this.Geolocation != null)
                    hashCode = hashCode * 59 + this.Geolocation.GetHashCode();
                hashCode = hashCode * 59 + this.DistanceFromLocation.GetHashCode();
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
