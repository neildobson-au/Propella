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
using OpenAPIDateConverter = Domain.Api.V1.Client.Client.OpenAPIDateConverter;

namespace Domain.Api.V1.Client.Model
{
    /// <summary>
    /// DomainLocationProfilesServiceV1ModelLocationDataPropertyCategories
    /// </summary>
    [DataContract(Name = "Domain.LocationProfilesService.v1.Model.LocationDataPropertyCategories")]
    public partial class DomainLocationProfilesServiceV1ModelLocationDataPropertyCategories : IEquatable<DomainLocationProfilesServiceV1ModelLocationDataPropertyCategories>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainLocationProfilesServiceV1ModelLocationDataPropertyCategories" /> class.
        /// </summary>
        /// <param name="luxuryLevelPrice">luxuryLevelPrice.</param>
        /// <param name="numberSold">numberSold.</param>
        /// <param name="estimatedRepayments">estimatedRepayments.</param>
        /// <param name="forSale">forSale.</param>
        /// <param name="medianSoldPrice">medianSoldPrice.</param>
        /// <param name="medianRentPrice">medianRentPrice.</param>
        /// <param name="daysOnMarket">daysOnMarket.</param>
        /// <param name="bedrooms">bedrooms.</param>
        /// <param name="forRent">forRent.</param>
        /// <param name="entryLevelPrice">entryLevelPrice.</param>
        /// <param name="salesGrowthList">salesGrowthList.</param>
        /// <param name="auctionClearanceRate">auctionClearanceRate.</param>
        /// <param name="propertyCategory">propertyCategory.</param>
        /// <param name="mostRecentSale">mostRecentSale.</param>
        public DomainLocationProfilesServiceV1ModelLocationDataPropertyCategories(double luxuryLevelPrice = default(double), int numberSold = default(int), double estimatedRepayments = default(double), int forSale = default(int), double medianSoldPrice = default(double), double medianRentPrice = default(double), double daysOnMarket = default(double), int bedrooms = default(int), int forRent = default(int), double entryLevelPrice = default(double), List<DomainLocationProfilesServiceV1ModelLocationDataSalesGrowthList> salesGrowthList = default(List<DomainLocationProfilesServiceV1ModelLocationDataSalesGrowthList>), double auctionClearanceRate = default(double), string propertyCategory = default(string), string mostRecentSale = default(string))
        {
            this.LuxuryLevelPrice = luxuryLevelPrice;
            this.NumberSold = numberSold;
            this.EstimatedRepayments = estimatedRepayments;
            this.ForSale = forSale;
            this.MedianSoldPrice = medianSoldPrice;
            this.MedianRentPrice = medianRentPrice;
            this.DaysOnMarket = daysOnMarket;
            this.Bedrooms = bedrooms;
            this.ForRent = forRent;
            this.EntryLevelPrice = entryLevelPrice;
            this.SalesGrowthList = salesGrowthList;
            this.AuctionClearanceRate = auctionClearanceRate;
            this.PropertyCategory = propertyCategory;
            this.MostRecentSale = mostRecentSale;
        }

        /// <summary>
        /// Gets or Sets LuxuryLevelPrice
        /// </summary>
        [DataMember(Name = "luxuryLevelPrice", EmitDefaultValue = false)]
        public double LuxuryLevelPrice { get; set; }

        /// <summary>
        /// Gets or Sets NumberSold
        /// </summary>
        [DataMember(Name = "numberSold", EmitDefaultValue = false)]
        public int NumberSold { get; set; }

        /// <summary>
        /// Gets or Sets EstimatedRepayments
        /// </summary>
        [DataMember(Name = "estimatedRepayments", EmitDefaultValue = false)]
        public double EstimatedRepayments { get; set; }

        /// <summary>
        /// Gets or Sets ForSale
        /// </summary>
        [DataMember(Name = "forSale", EmitDefaultValue = false)]
        public int ForSale { get; set; }

        /// <summary>
        /// Gets or Sets MedianSoldPrice
        /// </summary>
        [DataMember(Name = "medianSoldPrice", EmitDefaultValue = false)]
        public double MedianSoldPrice { get; set; }

        /// <summary>
        /// Gets or Sets MedianRentPrice
        /// </summary>
        [DataMember(Name = "medianRentPrice", EmitDefaultValue = false)]
        public double MedianRentPrice { get; set; }

        /// <summary>
        /// Gets or Sets DaysOnMarket
        /// </summary>
        [DataMember(Name = "daysOnMarket", EmitDefaultValue = false)]
        public double DaysOnMarket { get; set; }

        /// <summary>
        /// Gets or Sets Bedrooms
        /// </summary>
        [DataMember(Name = "bedrooms", EmitDefaultValue = false)]
        public int Bedrooms { get; set; }

        /// <summary>
        /// Gets or Sets ForRent
        /// </summary>
        [DataMember(Name = "forRent", EmitDefaultValue = false)]
        public int ForRent { get; set; }

        /// <summary>
        /// Gets or Sets EntryLevelPrice
        /// </summary>
        [DataMember(Name = "entryLevelPrice", EmitDefaultValue = false)]
        public double EntryLevelPrice { get; set; }

        /// <summary>
        /// Gets or Sets SalesGrowthList
        /// </summary>
        [DataMember(Name = "salesGrowthList", EmitDefaultValue = false)]
        public List<DomainLocationProfilesServiceV1ModelLocationDataSalesGrowthList> SalesGrowthList { get; set; }

        /// <summary>
        /// Gets or Sets AuctionClearanceRate
        /// </summary>
        [DataMember(Name = "auctionClearanceRate", EmitDefaultValue = false)]
        public double AuctionClearanceRate { get; set; }

        /// <summary>
        /// Gets or Sets PropertyCategory
        /// </summary>
        [DataMember(Name = "propertyCategory", EmitDefaultValue = false)]
        public string PropertyCategory { get; set; }

        /// <summary>
        /// Gets or Sets MostRecentSale
        /// </summary>
        [DataMember(Name = "mostRecentSale", EmitDefaultValue = false)]
        public string MostRecentSale { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainLocationProfilesServiceV1ModelLocationDataPropertyCategories {\n");
            sb.Append("  LuxuryLevelPrice: ").Append(LuxuryLevelPrice).Append("\n");
            sb.Append("  NumberSold: ").Append(NumberSold).Append("\n");
            sb.Append("  EstimatedRepayments: ").Append(EstimatedRepayments).Append("\n");
            sb.Append("  ForSale: ").Append(ForSale).Append("\n");
            sb.Append("  MedianSoldPrice: ").Append(MedianSoldPrice).Append("\n");
            sb.Append("  MedianRentPrice: ").Append(MedianRentPrice).Append("\n");
            sb.Append("  DaysOnMarket: ").Append(DaysOnMarket).Append("\n");
            sb.Append("  Bedrooms: ").Append(Bedrooms).Append("\n");
            sb.Append("  ForRent: ").Append(ForRent).Append("\n");
            sb.Append("  EntryLevelPrice: ").Append(EntryLevelPrice).Append("\n");
            sb.Append("  SalesGrowthList: ").Append(SalesGrowthList).Append("\n");
            sb.Append("  AuctionClearanceRate: ").Append(AuctionClearanceRate).Append("\n");
            sb.Append("  PropertyCategory: ").Append(PropertyCategory).Append("\n");
            sb.Append("  MostRecentSale: ").Append(MostRecentSale).Append("\n");
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
            return this.Equals(input as DomainLocationProfilesServiceV1ModelLocationDataPropertyCategories);
        }

        /// <summary>
        /// Returns true if DomainLocationProfilesServiceV1ModelLocationDataPropertyCategories instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainLocationProfilesServiceV1ModelLocationDataPropertyCategories to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainLocationProfilesServiceV1ModelLocationDataPropertyCategories input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LuxuryLevelPrice == input.LuxuryLevelPrice ||
                    this.LuxuryLevelPrice.Equals(input.LuxuryLevelPrice)
                ) && 
                (
                    this.NumberSold == input.NumberSold ||
                    this.NumberSold.Equals(input.NumberSold)
                ) && 
                (
                    this.EstimatedRepayments == input.EstimatedRepayments ||
                    this.EstimatedRepayments.Equals(input.EstimatedRepayments)
                ) && 
                (
                    this.ForSale == input.ForSale ||
                    this.ForSale.Equals(input.ForSale)
                ) && 
                (
                    this.MedianSoldPrice == input.MedianSoldPrice ||
                    this.MedianSoldPrice.Equals(input.MedianSoldPrice)
                ) && 
                (
                    this.MedianRentPrice == input.MedianRentPrice ||
                    this.MedianRentPrice.Equals(input.MedianRentPrice)
                ) && 
                (
                    this.DaysOnMarket == input.DaysOnMarket ||
                    this.DaysOnMarket.Equals(input.DaysOnMarket)
                ) && 
                (
                    this.Bedrooms == input.Bedrooms ||
                    this.Bedrooms.Equals(input.Bedrooms)
                ) && 
                (
                    this.ForRent == input.ForRent ||
                    this.ForRent.Equals(input.ForRent)
                ) && 
                (
                    this.EntryLevelPrice == input.EntryLevelPrice ||
                    this.EntryLevelPrice.Equals(input.EntryLevelPrice)
                ) && 
                (
                    this.SalesGrowthList == input.SalesGrowthList ||
                    this.SalesGrowthList != null &&
                    input.SalesGrowthList != null &&
                    this.SalesGrowthList.SequenceEqual(input.SalesGrowthList)
                ) && 
                (
                    this.AuctionClearanceRate == input.AuctionClearanceRate ||
                    this.AuctionClearanceRate.Equals(input.AuctionClearanceRate)
                ) && 
                (
                    this.PropertyCategory == input.PropertyCategory ||
                    (this.PropertyCategory != null &&
                    this.PropertyCategory.Equals(input.PropertyCategory))
                ) && 
                (
                    this.MostRecentSale == input.MostRecentSale ||
                    (this.MostRecentSale != null &&
                    this.MostRecentSale.Equals(input.MostRecentSale))
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
                hashCode = hashCode * 59 + this.LuxuryLevelPrice.GetHashCode();
                hashCode = hashCode * 59 + this.NumberSold.GetHashCode();
                hashCode = hashCode * 59 + this.EstimatedRepayments.GetHashCode();
                hashCode = hashCode * 59 + this.ForSale.GetHashCode();
                hashCode = hashCode * 59 + this.MedianSoldPrice.GetHashCode();
                hashCode = hashCode * 59 + this.MedianRentPrice.GetHashCode();
                hashCode = hashCode * 59 + this.DaysOnMarket.GetHashCode();
                hashCode = hashCode * 59 + this.Bedrooms.GetHashCode();
                hashCode = hashCode * 59 + this.ForRent.GetHashCode();
                hashCode = hashCode * 59 + this.EntryLevelPrice.GetHashCode();
                if (this.SalesGrowthList != null)
                    hashCode = hashCode * 59 + this.SalesGrowthList.GetHashCode();
                hashCode = hashCode * 59 + this.AuctionClearanceRate.GetHashCode();
                if (this.PropertyCategory != null)
                    hashCode = hashCode * 59 + this.PropertyCategory.GetHashCode();
                if (this.MostRecentSale != null)
                    hashCode = hashCode * 59 + this.MostRecentSale.GetHashCode();
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